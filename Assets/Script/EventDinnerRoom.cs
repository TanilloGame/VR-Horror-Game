using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] private GameObject monstruo;

    void OnTriggerEnter(Collider other)
    {
        monstruo.SetActive(true);
        Destroy(monstruo,8f);
        Debug.Log("TriggerComedor Activado");
    }
}
