using System;
using UnityEngine;

namespace PlayerSystems
{
    public class Actor
    {
        public Transform Transform { get; set; }
        public ActorModel Model { get; set; }
        public Kinematics Kinematics { get; set; }
        public Actor(Transform transform, ActorModel model, Kinematics kinematics)
        {
            Transform = transform;
            Model = model;
            Kinematics = kinematics;
        }
    }
}