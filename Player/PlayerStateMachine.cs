using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystems
{ 
    public class PlayerStateMachine
    {
        public IPlayerState InitialState { get; }
        private IPlayerState CurrentState { get; set; }

        public PlayerStateMachine(Actor _player, IPlayerState initialState)
        {
            InitialState = initialState;
            CurrentState = InitialState;
        }

        public void Execute()
        {
            CurrentState.Execute();
        }

        public void QueueInputAction(PlayerAction action, int actionValue)
        {
            CurrentState.QueueAction(action, actionValue);
        }
    }
}
