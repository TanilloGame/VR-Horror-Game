using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private GameObject door;
    [SerializeField] private bool needKey1 = false;
    [SerializeField] private bool needKey2 = false;
    [SerializeField] private AudioSource doorClosingAudioSource;
    [SerializeField] private AudioSource doorOpeningAudioSource;

    public void DoorInteraction()
    {
        if (needKey1 && PlayerInventory.HasKey1())
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
        else if (needKey2 && PlayerInventory.HasKey2())
        {
            // if (doorAnimator.GetBool("Open"))
            // {
            //     doorAnimator.SetBool("Open", false);
            //     doorClosingAudioSource.Play();
            // }
            // else
            // {
            //     doorAnimator.SetBool("Open", true);
            //     doorOpeningAudioSource.Play();
            // }
            SceneManager.LoadScene("MainMenu");
        }
        else if (!needKey1 && !needKey2)
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
}
