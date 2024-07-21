using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject root = other.gameObject.transform.root.gameObject;
        
        if (root.TryGetComponent(out CharacterState die))
        {
            if (die.KillFlag == false)
            {
                die.Kill();
                die.KillFlag = true;
            }
            
        }
    }
}
