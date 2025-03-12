using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerController : MonoBehaviour
{
    [SerializeField] private Animator lockerAnimator;

    void OnTriggerEnter(Collider other)
    {
        lockerAnimator.SetTrigger("TriggerOn");
        Debug.Log("Locker Opened");
    }
}
