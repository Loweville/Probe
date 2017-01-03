using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour 
{

    // Speed
    public Vector2 speed = new Vector2(10, 10);

    // Direction and Movement
    public Vector2 direction = new Vector2(0, -1);

    private Vector2 movement;

    void Update()
    {
        // Movement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);
    }

    void FixedUpdate()
    {
        // Move RigidBody
        rigidbody2D.velocity = movement;
    }
}
