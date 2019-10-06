// Script: CandyRotate.cs
// Desc: Script to handle candy rotation.
// Author: Jacob Anderson
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyRotate : MonoBehaviour
{
	private float rotX, rotY, rotZ;
    
	// Start is called before the first frame update
    void Start()
    {
        rotX = Random.Range(0.0f,0.5f) + 0.5f;
        rotY = Random.Range(0.0f, 0.5f) + 0.5f;
        rotZ = Random.Range(0.0f, 0.5f) + 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(rotX, rotY, rotZ);
    }
}
