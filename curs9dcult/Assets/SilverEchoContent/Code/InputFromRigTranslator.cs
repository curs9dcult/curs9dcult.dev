using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFromRigTranslator : MonoBehaviour
{

    public PlayerRigPicker player_rig_picker;
    public PlayerBallContoller ball_player_controller;



    public void SendMoveRequest()
    {

        // x - напрямки вліво вправо
        //y - напрямки вверх вниз
        //z - напрямки вперед назад

        Vector3 movement_direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));                  
        ball_player_controller.ball_movement_system.MoveByCamera(movement_direction);

    }
    public void SendRotateRequest() 
    {
        //Vector2 rotate_direction = camera_rotation_from_touchscreen.pixel_delta;

        ball_player_controller.ball_camera_system.RotateByX(Input.GetAxis("Mouse Y"));
        ball_player_controller.ball_camera_system.RotateByY(Input.GetAxis("Mouse X"));


    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        SendMoveRequest();
        SendRotateRequest();
    }
}
