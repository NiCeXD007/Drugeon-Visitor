using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Unity.VisualScripting;
using UnityEngine;

public class Die : MonoBehaviour
{
    [Button("Kill", ButtonSizes.Large)]
    public void Kill()
    {
        animator.enabled = false;
        RigidbodySwitch(false);
    }

    public bool KillFlag = false;
    private static List<Rigidbody> rigidbodies;
    private static Animator animator;
    private void OnEnable()
    {
        rigidbodies = new List<Rigidbody>(this.GetComponentsInChildren<Rigidbody>());
        animator = this.GetComponent<Animator>();
    }

    private static void RigidbodySwitch(bool state)
    {
        for (int i = 0; i < rigidbodies.Count; i++)
        {
            rigidbodies[i].isKinematic = state;
        }
    }
}
