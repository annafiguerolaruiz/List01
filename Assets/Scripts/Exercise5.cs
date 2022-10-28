using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{

    public Vector3[] positions;

    public GameObject capsulePrefab;
   

    void Update()
    {
        // Press S
        if (Input.GetKeyDown(KeyCode.S))
        {
            //The capsule is stored using the label of an array
            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsula");

            //Existing capsules are removed
            foreach (GameObject obj in capsulesInGame)
            {
                Destroy(obj);
            }

            //We create instance
            foreach (Vector3 pos in positions)
            {
                Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
            }
        }
    }
}

