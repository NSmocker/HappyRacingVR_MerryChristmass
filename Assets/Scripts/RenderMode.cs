using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderMode : MonoBehaviour
{
    public RenderTexture renderTexture;
    public GameObject userInterfaceImageObject;
    public RenderTexture Activate() 
    {
        userInterfaceImageObject.SetActive(true);
        return renderTexture;
    }
    public void Deactivate() 
    {
        userInterfaceImageObject.SetActive(false);
    }
   
}
