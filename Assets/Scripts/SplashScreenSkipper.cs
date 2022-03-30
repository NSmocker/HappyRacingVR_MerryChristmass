 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SplashScreenSkipper : MonoBehaviour
{
    public UnityEvent onTouch;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            if (Input.touches[0].phase == TouchPhase.Began) 
            {
                onTouch.Invoke();
            }
        }    
        if (Input.GetButtonDown("Fire1"))
        {
            onTouch.Invoke();
        }
    }
}
