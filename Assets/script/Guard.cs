using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform[] watchPoints;
    public float AICircle = 10f;
    public Transform mainTarget;
    private bool capture = false;
    public Transform callSoilders;
    public GameObject[] soilders;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(watchPoints[0].transform.position);
    }

    
    void Update()
    {
        float distance = Vector3.Distance(mainTarget.transform.position, transform.position);

        if (distance <= AICircle)
        {
            capture = true;
            agent.speed = 10f;
            agent.SetDestination(callSoilders.transform.position);
        }
    }

    private void OnGUI()
    {
        if (capture)
        {
            GUI.Box(new Rect(10,10,200,90),"i caught you");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point1"))
        {
            agent.SetDestination(watchPoints[1].transform.position);
        }

        if (other.CompareTag("Point2"))
        {
            agent.SetDestination(watchPoints[0].transform.position);
        }
        if (other.CompareTag("RunSoilders"))
        {
            soilders = GameObject.FindGameObjectsWithTag("Soilder");

            foreach (GameObject soilder in soilders)
            {
                soilder.GetComponent<Soilder>().isThereTarget = true;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AICircle);
    }
}
