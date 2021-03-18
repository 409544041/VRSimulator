using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trigger to stitch the heart back in

public class StitchingKidney : MonoBehaviour
{
    public Material cutLineMaterial;
    public CounterKidney counterScript;  

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
