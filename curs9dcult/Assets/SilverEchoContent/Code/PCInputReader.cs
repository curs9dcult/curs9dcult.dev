using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInputReader : MonoBehaviour
{
    public Vector2 user_move_input;
    public Vector2 user_cam_input;
    void ReadUserInputs()
    {
        user_move_input.x = Input.GetAxis("Horizontal");
        user_move_input.y = Input.GetAxis("Vertical");
        user_cam_input.x = Input.GetAxis("Mouse X");
        user_cam_input.y = Input.GetAxis("Mouse Y");


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadUserInputs();
    }
}
