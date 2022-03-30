using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GiftCounter : MonoBehaviour
{
    public int collectedGiftsCount;
    public int neededGiftsCount;
    public UnityEvent OnGiftsCollected;

    
    // Start is called before the first frame update
    void Start()
    {
        var giftsGOs = GameObject.FindGameObjectsWithTag("Gift");
        neededGiftsCount = giftsGOs.Length;
        foreach (GameObject giftObject in giftsGOs) 
        {
            giftObject.GetComponent<GiftBiheviour>().giftCounterLink = GetComponent<GiftCounter>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (neededGiftsCount>0 && collectedGiftsCount >= neededGiftsCount) 
        {
            OnGiftsCollected.Invoke();
        }
    }
}
