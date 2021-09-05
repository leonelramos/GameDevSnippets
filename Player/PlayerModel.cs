using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayerSystems
{ 
    [Serializable]
    public class ActorModel
    {
        [field: Range(0, float.MaxValue)]
        [field: SerializeField]
        public float Mass { get; set; }

        [field: SerializeField]
        public Vector3 MaxVelocity { get; set; }

        [field: SerializeField]
        public Vector3 MaxAcceleration { get; set; }

        [field: SerializeField]
        public Vector3 MaxSpin { get; set; }

        [field: SerializeField]
        public Vector3 MaxRotation { get; set; }

        [field: SerializeField]
        public float WalkSpeed { get; set; }
    }
}