using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTakeKey : MonoBehaviour
{

    [SerializeField] private GameObject hand;
    //[SerializeField] private AudioClip keySound;

    public void TakeKey1()
    {
        Debug.Log("You have taken the key!");
        PlayerInventory.TakeKey1();
    }

    public void TakeKey2()
    {
        Debug.Log("You have taken the key!");
        PlayerInventory.TakeKey2();
    }

    public void EventKeyHand()
    {
        hand.SetActive(true);
        Destroy(hand, 5f);
    }
}
