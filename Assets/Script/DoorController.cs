using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private GameObject door;

    public void DoorInteraction()
    {
        if (doorAnimator.GetBool("Open"))
        {
            doorAnimator.SetBool("Open", false);
        }
        else
        {
            doorAnimator.SetBool("Open", true);
        }
    }
}
