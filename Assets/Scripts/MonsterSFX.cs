// Script: MonsterSFX.cs
// Desc: Script to handle enemy sound effects.
// Author: Jacob Anderson
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSFX : MonoBehaviour
{
	private int chance;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chance = Random.Range(1, 1000 * (GameObject.FindGameObjectsWithTag("MonsterTag").Length));
		
		if(chance == 1 && !GetComponent<AudioSource>().isPlaying) {
			GetComponent<AudioSource>().Play();
		}
    }
}
