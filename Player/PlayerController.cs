using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystems 
{ 
    public class PlayerController : MonoBehaviour
    {
        private Player _player { get; set; }
        private PlayerInputAction _inputAction { get; set; }
        private PlayerStateMachine _stateMachine { get; set; }
    }
}
