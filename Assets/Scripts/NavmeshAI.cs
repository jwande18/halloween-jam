using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshAI : MonoBehaviour
{
    public Transform goal;
	public bool isStunned = false;
	public int stunTime = 0;
	public int canStun = 0;
	
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
			
			++canStun;
		}
		else if(isStunned) {
			canStun = 0;
			++stunTime;
		}
		
		if(stunTime > 150) {
			stunTime = 0;
			
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.speed = 8f;
			isStunned = false;
		}
    }
}
