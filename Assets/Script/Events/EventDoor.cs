using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour

{
    [SerializeField] private GameObject monstruo;

    void OnTriggerEnter(Collider other)
    {
        monstruo.SetActive(true);
        Destroy(monstruo, 1.5f);
        Destroy(gameObject);
        Debug.Log("TriggerDoor Activated");
    }
}

