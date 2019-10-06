// Script: FlashLightAttack.cs
// Desc: Script to handle flashlight collision detection.
// Author: Jacob Anderson
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlashLightAttack : MonoBehaviour
{	
	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.tag == "MonsterTag") {
			if(!collision.gameObject.GetComponent<AudioSource>().isPlaying) {
				collision.gameObject.GetComponent<AudioSource>().Play();
			}
			
			if(collision.gameObject.GetComponent<NavmeshAI>().canStun > 500) {
				collision.gameObject.GetComponent<NavmeshAI>().chaseState = true;
				collision.gameObject.GetComponent<NavMeshAgent>().speed = 0f;
				collision.gameObject.GetComponent<NavmeshAI>().isStunned = true;
			}
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
