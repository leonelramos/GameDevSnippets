using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystems 
{ 
    public class PlayerController : MonoBehaviour
    {
        private Transform _player;
        [field: SerializeField] private PlayerModel _model;
        private Kinematics _kinematics;
        private PlayerStateMachine _stateMachine;
        private PlayerInputAction _inputAction;

        private void Start()
        {
            _player = GetComponent<Transform>();
            _model = new PlayerModel();
            _stateMachine = new PlayerStateMachine();
            _inputAction = new PlayerInputAction();
            _kinematics = new Kinematics(Integrators.ConstantAccel);
        }

        private void Update()
        {
            UpdateKinematics();
            UpdatePlayer();
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
