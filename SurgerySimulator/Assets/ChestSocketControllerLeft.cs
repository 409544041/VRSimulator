using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChestSocketControllerLeft : MonoBehaviour
{

    public Counter counterScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        

        if (col.gameObject.tag == "LeftPeckWithXR")
        {
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LeftPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("ChestCubeLeft").transform.localScale = new Vector3(0, 0, 0);

            counterScript.leftpeck += 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
