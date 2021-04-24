using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInit : MonoBehaviour
{

    public GameObject OrangeEnemy;
    public GameObject RedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        OrangeEnemy.SetActive(false);
        RedEnemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
