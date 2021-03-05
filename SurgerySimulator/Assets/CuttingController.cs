using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CuttingController : MonoBehaviour
{
    public Material cutLineMaterial;

    public Counter counterScript;
    //public Material dimMaterial;

    // Start is called before the first frame update
    /*void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(0.007946257f, -0.002314204f, 0.002964611f);
        cube.transform.position = new Vector3(0.5421f, 1.237f, -3.0634f);
        cube.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
    }*/


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SliceLine")
        {
            transform.GetComponent<Renderer>().material = cutLineMaterial;
            counterScript.counterNumber += 1;
            


            //transform.GetComponent<hi>().enabled = false; //to disable a specific script
            transform.GetComponent<BoxCollider>().enabled = false;
            
            //this.enabled = false;
        }

        //Debug.Log("Hello");
        

    }


    
    void Update()
    {
        
    }
}
