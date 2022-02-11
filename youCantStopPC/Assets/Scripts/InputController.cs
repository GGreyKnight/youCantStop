using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public string inputSteerAxis = "Horizontal";
    public string inputThrottleAxis = "Vertical";

    public float ThrottleInput { get; private set; }

    public float SteerInput { get; private set; }

    public bool BreakInput { get; set; }

    public bool QuitInput { get; set; }


    void Start()
    {
        //goes forward whole time
        ThrottleInput = 1;
    }

    void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis);
        BreakInput = Input.GetKey(KeyCode.Space);
        QuitInput = Input.GetKeyDown(KeyCode.Escape);
        //ThrottleInput = Input.GetAxis(inputThrottleAxis); //car goes forward only forward
        
    }
}
