using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        // Pressing "space" we verify if it is even or odd
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (number % 2 == 0)
            {
                //In case that it is even
                textTMP.text = $"The number {number} is EVEN";
            }
            else
            {
                //In case it is odd
                textTMP.text = $"The number {number} is ODD";
            }
        }
    }
}