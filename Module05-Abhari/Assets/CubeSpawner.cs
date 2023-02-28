using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    int cubeMax = 100;
    int cubeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cubePrefab);    
    }

    // Update is called once per frame
    void Update()
    {
        if (cubeCount <= cubeMax)
        {
            // Instantiate(cubePrefab);
            GameObject cubeColor = Instantiate<GameObject>(cubePrefab);
            Material material = cubeColor.GetComponent<Renderer>().material;
            material.color = UnityEngine.Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
            cubeCount += 1;
        }
        
    }
}
