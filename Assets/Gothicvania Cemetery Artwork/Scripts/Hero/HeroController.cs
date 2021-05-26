using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Hero
{
    public class HeroController : MonoBehaviour
    {
        public float speed = 2f;

        private HeroStateMachine fsm;

        // States
        private HeroState idleState;
        private HeroState runningState;

        private void Start()
        {
            fsm = new HeroStateMachine();

            idleState = new IdleState(this, fsm);
            runningState = new RunningState(this, fsm);

            fsm.Start(idleState);

        }

        public void Move()
        {
            fsm.ChangeState(runningState);
        }

        public void Stop()
        {
            fsm.ChangeState(idleState);
        }
    }
}


