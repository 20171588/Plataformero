using Plataformero.Enemy;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMelee : MonoBehaviour
{

    private Animator animator;
    private GameObject contactPoint;

    [SerializeField]
    private float attackRange = 0.5f;

    [SerializeField]
    private int damage = 2;

    public float rate = 1f;
    private float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        contactPoint = transform.Find("ContactPoint").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > counter)
        {
            //Iniciar ataque
            Attack();
            counter = Time.time + rate;
        }
    }

    private void Attack()
    {
        animator.SetTrigger("attack");
        Collider2D[] colliders = Physics2D.OverlapCircleAll(contactPoint.transform.position, attackRange);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                Debug.Log("Hubo contacto");
                if (collider.CompareTag("Enemy"))
                {
                    collider.GetComponent<EnemyController>().Hurt(damage);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (contactPoint != null)
        {
            Gizmos.DrawWireSphere(contactPoint.transform.position, attackRange);
        }
    }

}
