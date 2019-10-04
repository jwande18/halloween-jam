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
			collision.gameObject.GetComponent<NavMeshAgent>().speed = 0;
			collision.gameObject.GetComponent<NavmeshAI>().isStunned = true;
		}
	}
	
	void OnTriggerExit(Collider collision) {
		if(collision.gameObject.tag == "MonsterTag") {
			collision.gameObject.GetComponent<NavMeshAgent>().speed = 3.5f;
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
