using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEnging.AI;

public class AIScripting : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent AI;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
}
