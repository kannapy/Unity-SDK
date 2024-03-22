using System;
using System.Collections;
using System.Collections.Generic;
using InsightXR.VR;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class HandAnimator : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    private TriggerInputDetector XRinput;
    public Animator handAnimator;


    private void Start()
    {
        XRinput = FindObjectOfType<TriggerInputDetector>();
    }

    void Update()
    {
        handAnimator.SetFloat("Trigger", pinchAnimationAction.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", gripAnimationAction.action.ReadValue<float>());
    }
    
}