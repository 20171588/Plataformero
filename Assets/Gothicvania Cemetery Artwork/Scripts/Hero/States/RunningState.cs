using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Hero
{
    public class RunningState : HeroState
    {

        private Rigidbody2D rb;
        private Animator animator;

        private float movement;
        private float speed;

        public RunningState(HeroController hero, HeroStateMachine fsm) : base(hero, fsm)
        {
            rb = hero.GetComponent<Rigidbody2D>();
            animator = hero.GetComponent<Animator>();
            speed = hero.speed;
        }

        public override void OnEnter()
        {
            base.OnEnter();
            animator.SetBool("isRunning", true);
        }

        public override void OnHandleInput()
        {
            base.OnHandleInput();
            movement = Input.GetAxisRaw("Horizontal");
        }

        public override void OnLogicUpdate()
        {
            base.OnLogicUpdate();
            if(movement == 0)
            {
                hero.Stop();
            }
        }

        public override void OnPhysicsUpdate()
        {
            base.OnPhysicsUpdate();
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);
        }
    }
}


