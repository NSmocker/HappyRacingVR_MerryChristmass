using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBiheviour : MonoBehaviour
{
    public GiftCounter giftCounterLink;
    public int giftOnCollect = 1;
    public GameObject popSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            giftCounterLink.collectedGiftsCount += giftOnCollect;
            Destroy(Instantiate(popSound, transform.position, Quaternion.identity),3f);
            Destroy(gameObject);


        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
