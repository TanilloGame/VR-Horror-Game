using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKnockingDoor : MonoBehaviour
{
    [SerializeField] private AudioSource knockingDoorAudioSource;

    [SerializeField] private bool isDone = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isDone)
        {
            knockingDoorAudioSource.Play();
            isDone = true;
        }
    }
}
