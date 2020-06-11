using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] path;
    public Transform playerDestination;

    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("SetPath", 0f, 6f);
    }

    void SetPath() {
        agent.destination = path[Random.Range(0, path.Length)].position;
    }
    //public void chase()
    //{
    //    agent.SetDestination(playerDestination.position);
    //}
    
}
