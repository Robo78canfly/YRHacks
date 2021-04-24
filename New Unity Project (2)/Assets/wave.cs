using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;

    // Number of regular red enemies to spawn
    int redSpawn = 10;
    int orangeSpawn = 5;
    void Start()
    {
        for (int i = 0; i < redSpawn; i++)
        {
            Instantiate(Enemy, new Vector3(-8.5f + (i * -2.0f), 0.75f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
