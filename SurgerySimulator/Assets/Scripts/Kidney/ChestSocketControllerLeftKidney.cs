using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//collider attached to ChestCubeLeft to see if the Left Peck collides with it, if it does then give it spawns in the left peck

public class ChestSocketControllerLeftKidney : MonoBehaviour
{
    public CounterKidney counterScript; //calls the Counter Script

    void OnTriggerEnter(Collider col)
    {  
        if (col.gameObject.tag == "LeftPeckWithXR")
        {
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0); //make it disappear
            GameObject.Find("LeftPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f); //make this one re appear
            GameObject.FindWithTag("ChestCubeLeft").transform.localScale = new Vector3(0, 0, 0); //make the cube disappear
            counterScript.leftpeck += 1; //increment the value in counter script to tell it that its done
        }
    }    
}
