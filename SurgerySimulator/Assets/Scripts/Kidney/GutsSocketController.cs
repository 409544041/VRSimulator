using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//collider attached to GutsCube to see if the guts collides with it, if it does then give it spawns in the guts 

public class GutsSocketController : MonoBehaviour
{
    public CounterKidney counterScript; //calls the Counter Script

    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "Guts")
        {
            GameObject.Find("GutsHP").transform.localScale = new Vector3(0, 0, 0); //make it disappear
            GameObject.Find("GutsHP2").transform.localScale = new Vector3(0.4372422f, 0.4063207f, 0.4828697f); //make this one re appear
            GameObject.Find("GutsCube").transform.localScale = new Vector3(0, 0, 0); //make the cube disappear
            transform.GetComponent<BoxCollider>().enabled = false;
            counterScript.gutscounter += 1; //increment the value in counter script to tell it that its done
        }
    }
}
