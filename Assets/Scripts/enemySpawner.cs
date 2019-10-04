using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public Transform prefabEnemy;
    public int step = 0;
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        step++;
        if (step > 1350)
        {
            step = 0;
            Transform c = Instantiate(prefabEnemy, transform.position, transform.rotation);
        }
    }

}