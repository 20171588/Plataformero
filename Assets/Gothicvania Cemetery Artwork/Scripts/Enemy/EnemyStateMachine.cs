using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Enemy
{
    public class EnemyStateMachine
    {
        private EnemyState currentState;

        public void Start(EnemyState initialState)
        {
            this.currentState = initialState;
            this.currentState.OnEnter();
        }

        public void ChangeState(EnemyState newState)
        {
            this.currentState.OnExit();
            this.currentState = newState;
            this.currentState.OnEnter();
        }

        public EnemyState GetCurrentState()
        {
            return currentState;
        }
    }
}


