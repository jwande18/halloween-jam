using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public Transform prefabEnemy;
	
	public void spawnEnemy() {
	    if (FindObjectOfType<GameManager>().totalCandy % 5 == 0)
        {
            Transform c = Instantiate(prefabEnemy, transform.position, transform.rotation);
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