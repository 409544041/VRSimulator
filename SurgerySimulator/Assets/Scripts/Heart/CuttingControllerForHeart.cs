using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//trigger to cut the heart out

public class CuttingControllerForHeart : MonoBehaviour
{
    public Material cutLineMaterial;
    public Counter counterScript;
   
    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "SliceVeinsTag")
        {
            transform.GetComponent<Renderer>().material = cutLineMaterial; //change colour on trigger
            counterScript.heartcutter += 1;
            transform.GetComponent<BoxCollider>().enabled = false; //to prevent incrementing twice 
        }
    }
}
