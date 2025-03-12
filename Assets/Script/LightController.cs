using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    [SerializeField] private Animator interruptorAnimator;

    [SerializeField] private GameObject luz;

    public void LightInteraction()
    {
        if (luz.activeInHierarchy)
        {
            luz.SetActive(false);
            interruptorAnimator.SetBool("On", false);
        }
        else
        {
            luz.SetActive(true);
            interruptorAnimator.SetBool("On", true);
        }
    }
}
