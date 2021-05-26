using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Plataformero.Hero
{
    public class HeroStateMachine
    {
        private HeroState currentState;

        public HeroState getCurrentState()
        {
            return currentState;
        }

        public void Start(HeroState initialState)
        {
            currentState = initialState;
            currentState.OnEnter();
        }

        public void ChangeState(HeroState newState)
        {
            currentState.OnExit();
            currentState = newState;
            currentState.OnEnter();
        }
    }
}


