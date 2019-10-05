using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu_s : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("next level");
        SceneManager.LoadScene(2);
    }

    public void goback()
    {
        Debug.Log("next level");
        SceneManager.LoadScene(0);
    }
    public void gooptions()
    {
        Debug.Log("next level");
        SceneManager.LoadScene(1);
    }
    public void ragequit()
    {
        Debug.Log("game exit");
        Application.Quit();
    }
    private void FixedUpdate()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("game exit");
        }

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(2);//restarts game
            Debug.Log("restart");
        }
    }


}
