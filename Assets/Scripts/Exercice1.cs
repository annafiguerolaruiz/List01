using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise1 : MonoBehaviour
{
    private int minNumber = 0;
    private int maxNumber = 50;

    public TextMeshProUGUI textTMP;

    // We will generate a random number (0-50)
    public void GenerateRandomNumber()
    {
        // The number appears on the screen
        textTMP.text = Random.Range(minNumber, maxNumber).ToString();
    }
}