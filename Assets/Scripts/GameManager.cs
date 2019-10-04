using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalCandy;
	public bool flashLightOn;
    public Text candyDisp;
	
    // Start is called before the first frame update
    void Start()
    {
		flashLightOn = false;
    }

    // Update is called once per frame
    public void addCandyCount(int value)
    {
        totalCandy += value;
        candyDisp.text = "Candy: " + totalCandy + "/25";
		
		// spawn enemy
		if(totalCandy % 5 == 0) {
			FindObjectOfType<enemySpawner>().spawnEnemy();
		}
    }
}
