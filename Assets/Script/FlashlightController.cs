using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class FlashlightController : MonoBehaviour
{

    [SerializeField] private GameObject flashlightLight;
    [SerializeField] private Material materialEmissive;
    public InputActionReference flashlightAction;

    private void OnEnable()
    {
        flashlightAction.action.performed += ToggleFlashlight;
        flashlightAction.action.Enable();
    }

    private void OnDisable()
    {
        flashlightAction.action.Disable();
        flashlightAction.action.performed -= ToggleFlashlight;
    }

    private void ToggleFlashlight(InputAction.CallbackContext context)
    {
        if(flashlightLight.activeInHierarchy)
        {
            flashlightLight.SetActive(false);
            materialEmissive.DisableKeyword("_EMISSION");
        }
        else
        {
            flashlightLight.SetActive(true);
            materialEmissive.EnableKeyword("_EMISSION");
        }
    }
    
}
