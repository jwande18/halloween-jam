// Script: collectible.cs
// Desc: Script to handle candy collection.
// Author: Dawson
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
	public bool collected = false;
	
    // Start is called before the first frame update
    void Start()
    {
    
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
			collected = true;
			
			if(collected) {
				FindObjectOfType<GameManager>().addCandyCount(1);
				Destroy(gameObject);
			}
        }
    }
}
