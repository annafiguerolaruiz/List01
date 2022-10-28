using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private int score = 0;

    private void Start()
    {
        // Counter at 0
        counter.text = score.ToString();
    }

    // A period is added, so the text changes
    public void AddPoint()
    {
        score++;

        counter.text = score.ToString();
    }
}