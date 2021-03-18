using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//collider attached to ChestCubeRight to see if the Right Peck collides with it, if it does then give it spawns in the right peck

public class ChestSocketControllerRightLiver : MonoBehaviour
{    
    public CounterLiver counterScript; //calls the Counter Script

    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "RighPeckWithXR")
        {
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0); //make it disappear
            GameObject.Find("RightPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f); //make this one re appear
            GameObject.FindWithTag("ChestCubeRight").transform.localScale = new Vector3(0, 0, 0); //make the cube disappear
            counterScript.rightpeck += 1; //increment the value in counter script to tell it that its done
        }
    }
}
