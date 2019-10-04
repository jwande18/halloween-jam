using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshAI : MonoBehaviour
{
    public Transform goal;
	public bool isStunned = false;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
		if(!isStunned) {
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.destination = goal.position;
		}
    }
}
