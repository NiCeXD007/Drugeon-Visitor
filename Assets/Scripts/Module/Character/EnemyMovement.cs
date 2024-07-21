using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 Target = new Vector3(100, 100, 100);
    private NavMeshAgent navMeshAgent;
    private void OnEnable()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Target = new Vector3(0, this.transform.position.y, 0);
    }

    private void Update()
    {
        navMeshAgent.destination = Target;
    }

}