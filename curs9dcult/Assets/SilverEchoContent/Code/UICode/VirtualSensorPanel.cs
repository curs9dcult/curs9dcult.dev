using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualSensorPanel : MonoBehaviour,IDragHandler,IEndDragHandler
{
    public Vector2 pixel_delta;
    public float sense_x = 1f;
    public float sense_y = 1f;
    public void OnDrag(PointerEventData eventData)
    {
        pixel_delta = eventData.delta;
        pixel_delta.x =     Mathf.Clamp(    pixel_delta.x ,     -20f,       20f )/sense_x;

        pixel_delta.y =     Mathf.Clamp(    pixel_delta.y,       -20f,       20f)/sense_y;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        pixel_delta = Vector2.zero;
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
