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
				collision.gameObject.GetComponent<NavMeshAgent>().speed = 0;
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
