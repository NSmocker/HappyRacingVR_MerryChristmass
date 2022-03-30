using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePadConnectChecker : MonoBehaviour
{
    public GameObject obj1, obj2;
    public int gamepad_count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gamepad_count = Input.GetJoystickNames().Length;
        if (gamepad_count <= 0)
        {

            obj1.SetActive(true);
            obj2.SetActive(true);
           

        }
        else 
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            print(Input.GetJoystickNames()[0]);
        }


    }
}
