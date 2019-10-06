// Script: NavmeshAI.cs
// Desc: Script to handle enemy AI.
// Author: Jacob Anderson & Morgan
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshAI : MonoBehaviour
{
    public Transform goal;
	public bool isStunned = false;
	public bool chaseState = false;
	public int stunTime = 0;
	public int canStun = 0;
	public int chaseTime = 0;
	
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
		
		if(stunTime > 150 && chaseState) {
			stunTime = 0;
			
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.speed = 10f;
			isStunned = false;
		}
		
		if(chaseState) {
			++chaseTime;
		}
		
		if(chaseTime > 300) {
			chaseState = false;
			chaseTime = 0;
			
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.speed = 5f;
		}
    }
}
