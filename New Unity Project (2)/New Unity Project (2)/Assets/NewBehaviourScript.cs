using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // It is also possible to set the position with a Vector2
        // This automatically sets the Z axis to 0
        transform.position = new Vector2(-8.5f, 0.75f);
        
    }
    bool part1 = false;
    bool part2 = false;
    bool part3 = false;
    bool part4 = false;
    bool part5 = false;

    void Update()
    {
        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        if (transform.position.x < -5.33 & part1 == false)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        } else
        {
            part1 = true;
        }

        if (part1 == true)
        {
            if (transform.position.y < 3.65 & part2 == false)
            {
                transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
            } else
            {
                part1 = false;
                part2 = true;
            }
        }

        if (part2 == true)
        {
            if (transform.position.x < -2.33 & part3 == false)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
            }
            else
            {
                part2 = false;
                part3 = true;
            }
        }

        if (part1 == true)
        {
            if (transform.position.y < 3.65 & part2 == false)
            {
                transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
            }
            else
            {
                part1 = false;
                part2 = true;
            }
        }

    }
}
