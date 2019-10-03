using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawnEnemy : MonoBehaviour
{
    public bool canSpawn = true;
    public int candyCount = 0;
    public bool gotCandy = false;

    public Transform prefabAgent;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
       // candyCount = player.GetComponent<collectCandy>().get.candyCount();
        
        if ((candyCount % 5 == 0) && (candyCount > 0) && (canSpawn))
        { //problem: while the player has collect 5, but not #6 .. .it keeps spawning
            Instantiate(prefabAgent, transform.position, Quaternion.identity);
            canSpawn = false;
           // isFive = true;
        }
        else if(candyCount % 5 != 0)
        {
            canSpawn = true;
        }
       // if (gotCandy == true && isFive == true)
      //  {
      //   
      //      isFive = false;
       // }
    }
}
