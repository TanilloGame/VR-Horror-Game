using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLights : MonoBehaviour
{
    [SerializeField] private GameObject light1;

    [SerializeField] private GameObject light2;
    
    [SerializeField] private Animator light1Animator;
    [SerializeField] private Animator light2Animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            light1Animator.SetTrigger("TriggerEventoLuces1");
            light2Animator.SetTrigger("TriggerEventoLuces2");
        }
    }
}
