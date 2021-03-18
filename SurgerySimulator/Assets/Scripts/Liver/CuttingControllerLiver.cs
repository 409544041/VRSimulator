using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Trigger for cutting the chest

public class CuttingControllerLiver : MonoBehaviour
{
    public Material cutLineMaterial;
    public CounterLiver counterScript;  

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SliceLine")
        {
            transform.GetComponent<Renderer>().material = cutLineMaterial; //change colour on trigger
            counterScript.chestcutter += 1;            
            transform.GetComponent<BoxCollider>().enabled = false; //to prevent incrementing twice      
        } 
    }
}