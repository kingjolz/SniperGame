using UnityEngine;
using System.Collections;

/// <summary>
/// This script is written simply to have the enemy soldiers move towards the player.
/// </summary>
public class EnemyMovement : MonoBehaviour
{

    public Transform goal;
    


    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    
}
