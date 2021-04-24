using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBoxDetection : MonoBehaviour
{
    GameObject redBall = GameObject.Find("redBall");
    GameObject greenHitbox = GameObject.FindWithTag("Player");
    Vector2 greenHitboxPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    Vector2 redBallPos = GameObject.Find("redBall").transform.position;

}
// Start is called before the first frame update
void Start()
    {
        int playerHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //when the bad guy touches the no no square 
        // the player loses a point of hp
        if (playerHP <= 1) { 
            if (redBallPos == greenHitboxPos) {
              playerHP = playerHP - 1;
            }
        }
        
    }
}
