using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{

    public Material[] COLORS;

    // Choose the color that will be assigned to the cylinder
    public void ChangeCylinderColor(int index)
    {
        switch (index)
        {
            
            case 0:
                gameObject.GetComponent<Renderer>().material = COLORS[0];
                break;

            case 1:
                gameObject.GetComponent<Renderer>().material =  COLORS[1];
                break;

            case 2:
                gameObject.GetComponent<Renderer>().material = COLORS[2];
                break;

            case 3:
                gameObject.GetComponent<Renderer>().material = COLORS[3];
                break;

            case 4:
                gameObject.GetComponent<Renderer>().material = COLORS[4];
                break;

            default:
                gameObject.GetComponent<Renderer>().material = COLORS[5];
                break;
            
        }
    }
}