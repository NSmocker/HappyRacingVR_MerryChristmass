using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomDisplaytransform : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI displayTextUI;
    [SerializeField]
    private GameObject mainCameraObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayTextUI.text = "Position:" + "\n" +
             " x -" + mainCameraObject.transform.localPosition.x.ToString() + "\n" +
            " y -" + mainCameraObject.transform.localPosition.y.ToString() + "\n" +
            " z -" + mainCameraObject.transform.localPosition.z.ToString() + "\n" +
            "Rotation euler " + "\n" +
             " x -" + mainCameraObject.transform.eulerAngles.x.ToString() + "\n" +
            " y -" + mainCameraObject.transform.eulerAngles.y.ToString() + "\n" +
            " z -" + mainCameraObject.transform.eulerAngles.z.ToString() + "\n";



    }
}
