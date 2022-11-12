using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class VirtualXRButton : MonoBehaviour
{
    public UnityEvent on_trigger_enter_custom;
    private void OnTriggerEnter(Collider other)
    {
        print("Toucghed");
        on_trigger_enter_custom.Invoke();
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
