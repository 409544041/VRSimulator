using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CuttingControllerForHeart : MonoBehaviour
{
    public Material cutLineMaterial;
    public Counter counterScript;
   
    void OnTriggerEnter(Collider col2)
    {
        Debug.Log("Hello");
        if (col2.gameObject.tag == "SliceVeinsTag")
        {
            Debug.Log("Hello again");
            transform.GetComponent<Renderer>().material = cutLineMaterial;
            counterScript.heartcutter += 1;
            transform.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void Update()
    {

    }
}
