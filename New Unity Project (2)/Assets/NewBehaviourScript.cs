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
    public float distanceTraveled = 0;
    bool part1 = false;
    bool part2 = false;
    bool part3 = false;
    bool part4 = false;
    bool part5 = false;
    bool part6 = false;
    bool part7 = false;

    void Update()
    {
        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        if (transform.position.x < -5.33 & part1 == false)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
            distanceTraveled += 1 * Time.deltaTime;
        } else
        {
            part1 = true;
        }

        if (part1 == true)
        {
            if (transform.position.y < 3.65 & part2 == false)
            {
                transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
                distanceTraveled += 1 * Time.deltaTime;
            } else
            {
                part2 = true;
            }
        }

        if (part2 == true)
        {
            if (transform.position.x < -2.33 & part3 == false)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0.05f *Time.deltaTime, 0);
                distanceTraveled += 1 * Time.deltaTime;
                distanceTraveled += 0.05f * Time.deltaTime;
            }
            else
            {
                part3 = true;
            }
        }

        if (part3 == true)
        {
            if (transform.position.y > -1.68 & part4 == false)
            {
                transform.position += new Vector3(-0.1f * Time.deltaTime, -1 * Time.deltaTime, 0);
                distanceTraveled += 0.1f * Time.deltaTime;
                distanceTraveled += 1 * Time.deltaTime;
            }
            else
            {
                part4 = true;
            }
        }

        if (part4 == true)
        {
            if (transform.position.x < -0.49 & part5 == false)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0.05f * Time.deltaTime, 0);
                distanceTraveled += 1 * Time.deltaTime;
                distanceTraveled += 0.05f * Time.deltaTime;
            }
            else
            {
                part5 = true;
            }
        }

        if (part5 == true)
        {
            if (transform.position.y < 0.88 & part6 == false)
            {
                transform.position += new Vector3(0.3f * Time.deltaTime, 1 * Time.deltaTime, 0);
                distanceTraveled += 1 * Time.deltaTime;
                distanceTraveled += 0.3f * Time.deltaTime;
            }
            else
            {
                part6 = true;
            }
        }
        if (part6 == true)
        {
            if (transform.position.x < 3.48 & part7 == false)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0.1f * Time.deltaTime, 0);
                distanceTraveled += 1 * Time.deltaTime;
                distanceTraveled += 0.1f * Time.deltaTime;
            }
            else
            {
                part7 = true;
            }
        }


    }
}
