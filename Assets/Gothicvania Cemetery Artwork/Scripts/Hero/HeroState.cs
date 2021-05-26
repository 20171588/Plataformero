using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plataformero.Hero
{
    public abstract class HeroState
    {
        protected HeroController hero;
        protected HeroStateMachine fsm;

        public HeroState(HeroController hero, HeroStateMachine fsm)
        {
            this.hero = hero;
            this.fsm = fsm;
        }

        public virtual void OnEnter() { }
        public virtual void OnExit() { }
        public virtual void OnHandleInput() { }
        public virtual void OnLogicUpdate() { }
        public virtual void OnPhysicsUpdate() { }

    }

}


