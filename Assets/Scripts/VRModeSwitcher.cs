using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RenderModeSelection 
{
    VirtualRelityMode,
    AugmentedRealityMode
}
public class VRModeSwitcher : MonoBehaviour
{
    public Camera renderCamera;


    public RenderMode virtualRealityMode;   
    public RenderMode augmantedRealityMode;
    public static RenderModeSelection renderModeSelection;
    public  RenderModeSelection objectRenderModeSelection;


    // Start is called before the first frame update
    void Start()
    {
       
        ApplyChanges();
    }
    public void ApplyChanges()
    {
        renderModeSelection = objectRenderModeSelection;
        if (renderModeSelection == RenderModeSelection.AugmentedRealityMode)
        {
            renderCamera.targetTexture = augmantedRealityMode.Activate();
            virtualRealityMode.Deactivate();
        }else if (renderModeSelection == RenderModeSelection.VirtualRelityMode)
        {
            renderCamera.targetTexture = virtualRealityMode.Activate();
            augmantedRealityMode.Deactivate();
        }

    }
    public void SwitchMode() 
    {
        if (objectRenderModeSelection == RenderModeSelection.VirtualRelityMode)
        {
            objectRenderModeSelection = RenderModeSelection.AugmentedRealityMode;
            ApplyChanges();
        }
        else if (objectRenderModeSelection == RenderModeSelection.AugmentedRealityMode) 
        {
            objectRenderModeSelection = RenderModeSelection.VirtualRelityMode;
            ApplyChanges();
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
