using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ChestSocketControllerRight : MonoBehaviour
{    
    public Counter counterScript;
    
    void Start()
    {

    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "RighPeckWithXR")
        {
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("ChestCubeRight").transform.localScale = new Vector3(0, 0, 0);

            counterScript.rightpeck += 1;
        }
    }

    void Update()
    {

    } 
}
