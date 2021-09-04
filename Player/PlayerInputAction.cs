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

        public void Init(InputActionAsset actionAsset)
        {
            _playerInput = gameObject.AddComponent<PlayerInput>();
            _playerInput.actions = actionAsset;
            _playerInput.notificationBehavior = PlayerNotifications.BroadcastMessages;
            _playerInput.defaultActionMap = _mainActionMap;
            _playerInput.currentActionMap = actionAsset.FindActionMap(_mainActionMap);
            _playerInput.currentActionMap.Enable();            
        }

        private void OnJumpAction()
        {
            Debug.Log("Jumped");
        }

        private void OnInteractAction()
        {
            Debug.Log("Interacted");
        }

        private void OnMoveUpAction()
        {
            Debug.Log("Moving Up");
        }

        private void OnMoveDownAction()
        {
            Debug.Log("Moving Down");
        }

        private void OnMoveLeftAction()
        {
            Debug.Log("Moving Left");
        }

        private void OnMoveRightAction()
        {
            Debug.Log("Moving Right");
        }
    }
}
