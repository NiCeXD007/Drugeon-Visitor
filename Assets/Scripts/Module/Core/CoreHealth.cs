using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreHealth : MonoBehaviour
{
    public float Health = 100f;

    public void ApplyAttack(float damage)
    {
        Health -= damage;
    }
}
