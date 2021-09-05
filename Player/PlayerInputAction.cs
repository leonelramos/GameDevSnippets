using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerSystems
{ 
    public class PlayerInputAction : MonoBehaviour
    {
        private PlayerInput _playerInput;
        private readonly string _mainActionMap = "MainActionMap";
        private bool _actionEnded = false;

        public PlayerAction Action { get; set; }
        public int ActionValue { get; set; }

        public void Init(InputActionAsset actionAsset)
        {
            _playerInput = gameObject.AddComponent<PlayerInput>();
            _playerInput.actions = actionAsset;
            _playerInput.notificationBehavior = PlayerNotifications.BroadcastMessages;
            _playerInput.defaultActionMap = _mainActionMap;
            _playerInput.currentActionMap = actionAsset.FindActionMap(_mainActionMap);
            _playerInput.currentActionMap.Enable();

            Action = PlayerAction.None;
            ActionValue = 0;
        }

        public void UpdateAction()
        {
            if (_actionEnded)
            {
                Action = PlayerAction.None;
            }
        }

        private void OnJumpAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.JumpAction, inputValue.Get<int>());
        }

        private void OnInteractAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.InteractAction, inputValue.Get<int>());
        }

        private void OnMoveUpAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.MoveUpAction, inputValue.Get<int>());
        }

        private void OnMoveDownAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.MoveDownAction, inputValue.Get<int>());
        }

        private void OnMoveLeftAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.MoveLeftAction, inputValue.Get<int>());
        }

        private void OnMoveRightAction(InputValue inputValue)
        {
            SetActionContext(PlayerAction.MoveRightAction, inputValue.Get<int>());
        }

        private void SetActionContext(PlayerAction action, int actionValue)
        {
            Action = action;
            ActionValue = actionValue;

            if (actionValue == 0)
            {
                _actionEnded = true;
            }
            else
            {
                _actionEnded = false;
            }
        }
    }
}
