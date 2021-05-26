using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Enemy
{
    public class EnemyController : MonoBehaviour
    {

        public int health;

        private EnemyStateMachine fsm;
        public float speed;

        //States
        private EnemyState spawningState;
        private EnemyState walkingState;
        private EnemyState dyingState;

        // Start is called before the first frame update
        void Start()
        {
            fsm = new EnemyStateMachine();

            spawningState = new SpawningState(this, fsm);
            walkingState = new WalkingState(this, fsm);
            dyingState = new DyingState(this, fsm);

            // Seteo estado inicial
            fsm.Start(spawningState);
            fsm.ChangeState(walkingState);
        }

        private void FixedUpdate()
        {
            fsm.GetCurrentState().OnPhysicsUpdate();
        }

        // Update is called once per frame
        void Update()
        {
            fsm.GetCurrentState().OnHandleInput();
            fsm.GetCurrentState().OnLogicUpdate();
        }

        public void Hurt(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                fsm.ChangeState(dyingState);
            }
        }
    }
}


