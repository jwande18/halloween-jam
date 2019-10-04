using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class healthcount : MonoBehaviour
{

    public int healthpool = 3;
    public Image h1;
    public Image h2;
    public Image h3;
    public bool sub;




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MonsterTag")
            {
            if (sub == true)
            {
                healthpool -= 1;
                sub = false;
            }

            Destroy(other.gameObject);
            print("monster col");
            }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        sub = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(healthpool==2)
        {
            h3.enabled = false;
            sub = true;
        }
        if (healthpool==1)
        {
            h2.enabled = false;
            sub = true;
        }

        if (healthpool == 0)
        {
            h1.enabled = false;
            sub = true;
        }
        if (healthpool==0)
        {
            Debug.Log("next level");
            SceneManager.LoadScene("lose scene");
        }
    }



}
