using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody ball_rigidbody;
    public Transform direction_pointer;
    public GroundCheckerBihaviour ground_checker_system;
    public float move_speed;
    public float jump_force;


    public void MoveByCamera(Vector3 local_direction) 
    {
        var transformed_direction = direction_pointer.TransformDirection(local_direction);

        ball_rigidbody.AddForce(transformed_direction * move_speed);
    }
    public void MakeJump()
    {
      if(ground_checker_system.is_grounded) ball_rigidbody.AddForce(Vector3.up* jump_force);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
