using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerSystems 
{ 
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionAsset _actionAsset;
        [SerializeField] private PlayerModel _model;

        private PlayerInputAction _inputAction;
        private Transform _player;
        private PlayerStateMachine _stateMachine;
        private Kinematics _kinematics;
        
        private void Start()
        {
            _inputAction = gameObject.AddComponent<PlayerInputAction>();
            _inputAction.Init(_actionAsset);
            _model = new PlayerModel();
            _player = GetComponent<Transform>();
            _stateMachine = new PlayerStateMachine();
            _kinematics = new Kinematics(Integrators.ConstantAccel);
        }

        private void Update()
        {
           // UpdateKinematics();
           // UpdatePlayer();
        }

        private void UpdatePlayer()
        {
            _player.position = _kinematics.Position;
        }

        private void UpdateKinematics()
        {
            _kinematics.DeltaTime = Time.deltaTime;
            _kinematics.Integrate();
        }
    }
}
