using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Plataformero.Enemy
{
    public class SpawningState : EnemyState
    {

        private Slider slider;

        public SpawningState(EnemyController enemy, EnemyStateMachine fsm) : base(enemy, fsm)
        {
            slider = enemy.transform.Find("Canvas").Find("Healthbar").GetComponent<Slider>();
        }

        public override void OnEnter()
        {
            base.OnEnter();
            slider.value = enemy.health;
            slider.maxValue = enemy.health;
            slider.minValue = 0f; 
        }
    }
}

