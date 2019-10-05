using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCandy : MonoBehaviour
{
    private int candyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "candy")
        {
            //gotCandy = true;
            candyCount++;
            
        }
    }

    public int totalcandy()
    {
        return candyCount;
    }
}
