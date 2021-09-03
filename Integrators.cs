using UnityEngine;

public static class Integrators 
{
    public static (Vector3, Vector3) ConstantAccel(Vector3 position, Vector3 velocity, Vector3 acceleration, float deltaTime)
    {
        position += (velocity + 0.5f * acceleration * deltaTime) * deltaTime;
        velocity += acceleration * deltaTime;
        return (position, velocity);
    }

    public static (Vector3, Vector3) ExplicitEuler(Vector3 position, Vector3 velocity, Vector3 acceleration, float deltaTime)
    {
        position += velocity * deltaTime;
        velocity += acceleration * deltaTime;
        return (position, velocity);
    }

    public static (Vector3, Vector3) ImplicitEuler(Vector3 position, Vector3 velocity, Vector3 acceleration, float deltaTime)
    {
        velocity += acceleration * deltaTime;
        position += velocity * deltaTime;
        return (position, velocity);
    }

    // TODO: Add Runge-Kutta and Verlet
}
