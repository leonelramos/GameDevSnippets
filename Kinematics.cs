using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematics
{
    public delegate (Vector3, Vector3) IntegratorDelegate(Vector3 position, Vector3 velocity, Vector3 acceleration, float deltaTime);
    public IntegratorDelegate Integrator { get; set; }
    public Vector3 Position { get; set; }
    public Vector3 Velocity { get; set; }
    public Vector3 Acceleration { get; set; }
    public Vector3 Spin { get; set; }
    public Vector3 Rotation { get; set; }
    public float DeltaTime { get; set; }
    public void Integrate()
    {
        (Vector3 Position, Vector3 Velocity) result = Integrator(Position, Velocity, Acceleration, DeltaTime);
        Position = result.Position;
        Velocity = result.Velocity;
    }
}
