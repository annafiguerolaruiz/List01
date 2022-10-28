using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{

    // The scale of the object is changed using the slider
    public void ChangeObjectScale(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
}