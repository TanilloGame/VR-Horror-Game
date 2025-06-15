using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour

{
    [SerializeField] private GameObject monstruo;
    [SerializeField] private float timeDuration;

    void OnTriggerEnter(Collider other)
    {
        monstruo.SetActive(true);
        Destroy(monstruo, timeDuration);
        Destroy(gameObject);
        Debug.Log("TriggerDoor Activated");
    }
}

