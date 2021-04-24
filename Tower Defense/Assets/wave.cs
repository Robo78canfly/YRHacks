using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RedEnemy;
    public GameObject OrangeEnemy;
    // Number of regular red enemies to spawn
    void Start()
    {
    }

    double time = 0;
    bool wave1 = false;
    bool wave2 = false;
    bool wave3 = false;
    bool wave4 = false;
    bool wave5 = false;
    bool wave6 = false;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2 & wave1 == false)
        {
            wave1 = true;
            RedEnemy.SetActive(true);
            for (int i = 0; i < 10; i++)
            {
                Instantiate(RedEnemy, new Vector3(-8.5f + (i * -2.0f), 0.75f, 0), Quaternion.identity);
            }
            RedEnemy.SetActive(false);
        }

        if (time > 15 & wave2 == false & GameObject.Find("RedEnemy(Clone)") == null)
        {
            wave2 = true;
            RedEnemy.SetActive(true);
            for (int i = 0; i < 5; i++)
            {
                Instantiate(RedEnemy, new Vector3(-8.5f + (i * -1.0f), 0.75f, 0), Quaternion.identity);
            }
            RedEnemy.SetActive(false);
            OrangeEnemy.SetActive(true);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(OrangeEnemy, new Vector3(-8.5f + (i * -1.0f), 0.75f, 0), Quaternion.identity);
            }
            OrangeEnemy.SetActive(false);
        }


    }
}
