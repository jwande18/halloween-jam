using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlashLightAttack : MonoBehaviour
{	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "MonsterTag") {
			collision.gameObject.GetComponent<NavMeshAgent>().speed = 0;
			collision.gameObject.GetComponent<NavmeshAI>().isStunned = true;
		}
	}
	
	void OnCollisionExit(Collision collision) {
		if(collision.gameObject.tag == "MonsterTag") {
			collision.gameObject.GetComponent<NavMeshAgent>().speed = 5;
			collision.gameObject.GetComponent<NavmeshAI>().isStunned = false;
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
