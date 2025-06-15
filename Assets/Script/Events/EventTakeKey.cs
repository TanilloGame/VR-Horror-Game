using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTakeKey : MonoBehaviour
{

    [SerializeField] private GameObject hand;
    [SerializeField] private AudioClip keySound;

    public void TakeKey1()
    {
        PlayerInventory.TakeKey1();
        Debug.Log("You have taken the key!");
        hand.SetActive(true);
        Destroy(gameObject, 3f);
    }
}
