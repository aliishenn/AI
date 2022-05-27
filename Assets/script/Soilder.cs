using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Soilder : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform target;
    public bool isThereTarget;


    void Start()
    {       
        agent=GetComponent<NavMeshAgent>();
        isThereTarget = false;
    }

    private void Update()
    {
        if (isThereTarget)
        {
            agent.SetDestination(target.transform.position);
        }

    }
}
