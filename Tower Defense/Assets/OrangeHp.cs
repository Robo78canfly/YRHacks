using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeHp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    public GameObject OrangeEnemy;
    private orangeEnemy orangeEnemy;
    void Start()
    {
        orangeEnemy = OrangeEnemy.GetComponent<orangeEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.GetComponent<Text>().text = (orangeEnemy.health.ToString());
    }
}
