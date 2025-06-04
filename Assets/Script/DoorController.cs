using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private GameObject door;
    [SerializeField] private bool hasKey = false;
    [SerializeField] private AudioSource doorClosingAudioSource;
    [SerializeField] private AudioSource doorOpeningAudioSource;

    public void DoorInteraction()
    {
        if (hasKey)
        {
            if (doorAnimator.GetBool("Open"))
            {
                doorAnimator.SetBool("Open", false);
                doorClosingAudioSource.Play();
            }
            else
            {
                doorAnimator.SetBool("Open", true);
                doorOpeningAudioSource.Play();
            }
        }
    }

    public void SetKeyTrue()
    {
        hasKey = true;
    }
}
