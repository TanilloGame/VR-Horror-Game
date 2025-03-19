using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private GameObject door;
    [SerializeField] private bool hasKey = false;

    public void DoorInteraction()
    {
        if (hasKey)
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

    public void SetKeyTrue()
    {
        hasKey = true;
    }
}
