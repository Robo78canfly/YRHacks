using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedHp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    public GameObject RedEnemy;
    private redEnemy redEnemy;
    void Start()
    {
        redEnemy = RedEnemy.GetComponent<redEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.GetComponent<Text>().text = (redEnemy.health.ToString());
    }
}
