using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Plataformero.Enemy
{
    public class WalkingState : EnemyState
    {

        private Rigidbody2D rb;
        private float speed;
        private Slider slider;

        public WalkingState(EnemyController enemy, EnemyStateMachine fsm) : base(enemy, fsm)
        {
            rb = enemy.GetComponent<Rigidbody2D>();
            speed = enemy.speed;
            slider = enemy.transform.Find("Canvas").Find("Healthbar").GetComponent<Slider>();
        }

        public override void OnLogicUpdate()
        {
            base.OnLogicUpdate();
            slider.value = enemy.health;
        }

        public override void OnPhysicsUpdate()
        {
            base.OnPhysicsUpdate();
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }

}

