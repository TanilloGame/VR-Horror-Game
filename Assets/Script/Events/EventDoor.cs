using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour

{
    [SerializeField] private GameObject monstruo;

    void OnTriggerEnter(Collider other)
    {
        monstruo.SetActive(true);
        Destroy(monstruo, 5f);
        Destroy(gameObject);
        Debug.Log("TriggerDoor Activated");
    }
}

