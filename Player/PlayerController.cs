using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystems 
{ 
    public class PlayerController : MonoBehaviour
    {
        private Transform _player;
        private PlayerModel _model;
        private Kinematics _kinematics;
        private PlayerStateMachine _stateMachine;
        private PlayerInputAction _inputAction;

        private void Start()
        {
            _player = GetComponent<Transform>();
        }

        private void Update()
        {
            UpdatePosition();
            UpdateKinematics();
        }

        private void UpdateKinematics()
        {
            _kinematics.Velocity += _kinematics.Acceleration * Time.deltaTime;
        }

        private void UpdatePosition()
        {
            _kinematics.Position = (_kinematics.Velocity + 0.5f * _kinematics.Acceleration * Time.deltaTime) * Time.deltaTime;
            _player.position = _kinematics.Position;
        }
    }
}
