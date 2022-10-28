using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroy : MonoBehaviour
{
    private Exercise10 manager;

    private void Start()
    {
        // Receive the script (exercise 10) as a priority
        manager = FindObjectOfType<Exercise10>();
    }

    private void OnMouseOver()
    {
        // Click on the sphere
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Add point to score
            manager.AddPoint();

            // Destroy the sphere
            Destroy(gameObject);
        }
    }
}