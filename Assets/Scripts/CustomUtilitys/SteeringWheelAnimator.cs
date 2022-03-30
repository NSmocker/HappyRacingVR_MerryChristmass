using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelAnimator : MonoBehaviour
{
    public GameObject wheel;

    public float x_input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_input = Input.GetAxis("Horizontal");
        var angle = wheel.transform.localEulerAngles;
        angle.z = x_input * 45;
        wheel.transform.localEulerAngles = angle;
    }
}
