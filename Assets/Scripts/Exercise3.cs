using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    // Screen limits
    private float xRange = 3f;
    private float yRange = 2f;
    private float zRange = 3f;

    // Random values ​​OF POSITIONS
    private float xPosition, yPosition, zPosition;
   

    void Update()
    {
        // Press the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Random positions are generated within the limits of the camera
            xPosition=Random.Range(-xRange, xRange);
            yPosition=Random.Range(-yRange, yRange);
            zPosition=Random.Range(-zRange, zRange);

            // The cube moves randomly
            transform.position=new Vector3(xPosition, yPosition, zPosition);
        }
    }
}