using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trigger to stitch the liver back in

public class StitchingLiver : MonoBehaviour
{
    public Material cutLineMaterial;
    public CounterLiver counterScript;  

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Needle")
        {
            transform.GetComponent<Renderer>().material = cutLineMaterial;
            counterScript.stichescounter += 1;
            transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
