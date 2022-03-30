using UnityEngine;
using UnityEngine.Events;


public class VirtualButtonBihevour : MonoBehaviour
{
    public UnityEvent onActivateEvent;
    public Animator anim;
    public bool isLooking;
    public void ActivateEvent() 
    {
        onActivateEvent.Invoke();
    }


    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        onActivateEvent.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isLooking = VirtualUIRaycaster.lookingAt == gameObject;
        anim.SetBool("isLooking", isLooking);
    }
}
