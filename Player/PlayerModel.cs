using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayerSystems
{ 
    [Serializable]
    public class PlayerModel
    {
        [field: Range(0, float.MaxValue)]
        [field: SerializeField]
        private float Mass { get; set; }

        [field: SerializeField]
        private Vector3 MaxVelocity { get; set; }

        [field: SerializeField]
        private Vector3 MaxAcceleration { get; set; }

        [field: SerializeField]
        private Vector3 MaxSpin { get; set; }

        [field: SerializeField]
        private Vector3 MaxRotation { get; set; }
    }
}