using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Die : MonoBehaviour
{
    [Button("Kill", ButtonSizes.Large)]
    public void Kill()
    {
        animator.enabled = false;
        enemyMovement.enabled = false;
        navMeshAgent.enabled = false;
        
        RigidbodySwitch(false);
    }

    public bool KillFlag = false;
    private static List<Rigidbody> rigidbodies;
    private static Animator animator;
    private static NavMeshAgent navMeshAgent;
    private static EnemyMovement enemyMovement;
    private void OnEnable()
    {
        rigidbodies = new List<Rigidbody>(this.GetComponentsInChildren<Rigidbody>());
        animator = this.GetComponent<Animator>();
        enemyMovement = this.GetComponent<EnemyMovement>();
        navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float speed = navMeshAgent.speed;
        if (speed > 0.1f)
        {
            animator.SetInteger("State", 1);
        }
        else
        {
            animator.SetInteger("State", 0);
        }
    }

    private static void RigidbodySwitch(bool state)
    {
        for (int i = 0; i < rigidbodies.Count; i++)
        {
            rigidbodies[i].isKinematic = state;
        }
    }
}
