using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum EnemyState
{
    Spawn, Walk, Destroy
}

public class EnemyMovement : MonoBehaviour
{

    private EnemyState state;
    private Rigidbody2D rb;
    private Animator animator;
    private Slider slider;
    
    [SerializeField]
    private float speed = 2f;

    [SerializeField]
    private int health = 10;


    // Start is called before the first frame update
    void Start()
    {
        state = EnemyState.Walk;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        slider = transform.Find("Canvas").Find("Healthbar").GetComponent<Slider>();
        slider.maxValue = health;
        slider.minValue = 0f;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(state == EnemyState.Walk)
        {
            Walk();
        }
    }

    private void Walk()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ContactPoint")){
            Debug.Log("Le pego al enemigo");
        }
    }

    public void Hurt(int damage)
    {
        health -= damage;
        slider.value -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        animator.SetTrigger("destroy");
        state = EnemyState.Destroy;
    }
}
