using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] private GameObject monstruo;
    [SerializeField] private AudioSource audioSourceMonstruo;

    void OnTriggerEnter(Collider other)
    {
        monstruo.SetActive(true);
        audioSourceMonstruo.Play();
        Destroy(monstruo,5.5f);
        Destroy(gameObject);
        Debug.Log("TriggerComedor Activado");
    }
}
