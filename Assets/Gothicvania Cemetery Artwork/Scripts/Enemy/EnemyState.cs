using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Enemy
{
    public abstract class EnemyState
    {
        protected EnemyController enemy;
        protected EnemyStateMachine fsm;
        public EnemyState(EnemyController enemy, EnemyStateMachine fsm)
        {
            this.enemy = enemy;
            this.fsm = fsm;
        }

        public virtual void OnEnter() { }      
        public virtual void OnExit() { }
        public virtual void OnHandleInput() { }
        public virtual void OnLogicUpdate() { }
        public virtual void OnPhysicsUpdate() { }
    }

}
