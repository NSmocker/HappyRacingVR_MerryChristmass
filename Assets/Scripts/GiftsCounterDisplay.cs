using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GiftsCounterDisplay : MonoBehaviour
{
    public GiftCounter giftCounterLink;
    public TextMeshPro giftsNeedDisplay;
    public TextMeshPro giftsCollectedDisplay;

    // Start is called before the first frame update
    void Start()
    {
        giftCounterLink = GameObject.Find("GiftCounter").GetComponent<GiftCounter>();
        
    }

    // Update is called once per frame
    void Update()
    {
        giftsCollectedDisplay.text = "Gifts Collected: " + giftCounterLink.collectedGiftsCount.ToString();
        giftsNeedDisplay.text = "Gifts Need: " + giftCounterLink.neededGiftsCount.ToString();

    }
}
