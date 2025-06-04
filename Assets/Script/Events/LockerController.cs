using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerController : MonoBehaviour
{
    [SerializeField] private Animator lockerAnimator;

    [SerializeField] private string nameAnimation;

    [SerializeField] private AudioSource lockerAudio;

    [SerializeField] private bool animationDone = false;

    void OnTriggerEnter(Collider other)
    {
        if (!animationDone)
        {
            lockerAnimator.SetTrigger(nameAnimation);
            lockerAudio.Play();
            animationDone = true;
            Debug.Log("Locker Opened");
            Destroy(gameObject);
        }
    }
}
