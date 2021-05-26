using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Plataformero.Enemy
{
    public class DyingState : EnemyState
    {

        private Animator animator;
        private Rigidbody2D rb;
        private Slider slider;


        public DyingState(EnemyController enemy, EnemyStateMachine fsm) : base(enemy, fsm)
        {
            animator = enemy.GetComponent<Animator>();
            rb = enemy.GetComponent<Rigidbody2D>();
            slider = enemy.transform.Find("Canvas").Find("Healthbar").GetComponent<Slider>();
        }

        public override void OnEnter()
        {
            base.OnEnter();
            slider.value = 0f;
            animator.SetTrigger("destroy");
            rb.velocity = Vector2.zero;
        }


    }
}


