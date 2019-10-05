using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (totalCandy == 25)
        {
            //checks if requirement is met to change scenes
            SceneManager.LoadScene(4);
        }
    }
}
