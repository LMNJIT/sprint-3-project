using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetMovement : MonoBehaviour
{
    public Transform Petpos;
   // public Transform Enemypos;
    public Transform Playerpos;
    Animation animate;

    int LookRadius = 5;
    NavMeshAgent agent;
    void Start() {
        // Grab NavMeshAgent
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        // Make the pet hover around the player's location
       /* if (Vector3.Distance(Petpos.position, Enemypos.position) < LookRadius) {
            // Set the pet so that it starts moving towards the enemy's position (updated every frame)
            agent.SetDestination(Enemypos.position);

        }*/

        if (Vector3.Distance(Petpos.position, Playerpos.position) > 5.0f) {
            // Make it so the pet follows the player
            agent.SetDestination(Playerpos.position);
        }

        else {
            agent.SetDestination(transform.position);
        }
    }
}
