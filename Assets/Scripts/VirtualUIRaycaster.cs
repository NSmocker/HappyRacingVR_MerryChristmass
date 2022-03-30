using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualUIRaycaster : MonoBehaviour
{
    public Camera mainCam;
    public static GameObject lookingAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            lookingAt = hit.collider.gameObject;
            print("Looking at" + lookingAt.name);
        }
        else { lookingAt = null; }

    }
}
