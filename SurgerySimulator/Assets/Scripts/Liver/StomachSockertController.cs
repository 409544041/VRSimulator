using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//collider attached to StomachCube to see if the stomach collides with it, if it does then give it spawns in the stomach 

public class StomachSockertController : MonoBehaviour
{
    public CounterLiver counterScript; //calls the Counter Script

    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "Stomach")
        {
            GameObject.Find("Stomach").transform.localScale = new Vector3(0, 0, 0); //make it disappear
            GameObject.Find("Stomach2").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); //make this one re appear
            GameObject.Find("StomachCube").transform.localScale = new Vector3(0, 0, 0); //make the cube disappear
            transform.GetComponent<BoxCollider>().enabled = false;
            counterScript.stomachcounter += 1; //increment the value in counter script to tell it that its done
        }
    }
}
