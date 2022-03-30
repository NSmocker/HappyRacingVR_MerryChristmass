using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchFromInput : MonoBehaviour
{
    public AudioSource source;
    public float input_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input_y = Input.GetAxis("Vertical");
        source.pitch = Mathf.Abs(input_y) + 0.8f;
        
    }
}
