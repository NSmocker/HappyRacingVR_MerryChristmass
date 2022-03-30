using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public enum LookingControl 
{
    Mouse,ARRigCopy
}
public class TransformCopyPaster : MonoBehaviour
{
    public GameObject copyPositionObject;
    public Vector3 positionOffset;
    public  LookingControl lookingControll = LookingControl.ARRigCopy;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void RecenterCamera() 
    {
        positionOffset = -copyPositionObject.transform.localPosition;
    }
    // Update is called once per frame
    void Update()
    {


        if (lookingControll == LookingControl.ARRigCopy) 
        {
            transform.localPosition = copyPositionObject.transform.localPosition + positionOffset;
            transform.rotation = copyPositionObject.transform.rotation;
            if (Input.GetButtonDown("Jump"))
            {
                RecenterCamera();
            }
        }
        if (lookingControll == LookingControl.Mouse)
        {
            float mouse_sense = 50;
            Vector2 mouseLook = new Vector2(Input.GetAxis("Mouse X") * mouse_sense, Input.GetAxis("Mouse Y") * mouse_sense);
            print(mouseLook);
            transform.eulerAngles += new Vector3(-mouseLook.y * Time.deltaTime, mouseLook.x * Time.deltaTime, 0);
            
        }





    }
}
