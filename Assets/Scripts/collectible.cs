using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        value = 1;
    }

   
    private void OnTriggerEnter(Collider other)
    {
        print("Collision");
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().addCandyCount(value);
            Destroy(gameObject);
        }
    }
}
