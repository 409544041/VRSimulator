using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchingHeart : MonoBehaviour
{
    public Material cutLineMaterial;

    public Counter counterScript;
    




    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Needle")
        {
            transform.GetComponent<Renderer>().material = cutLineMaterial;
            counterScript.stichescounter += 1;



            //transform.GetComponent<hi>().enabled = false; //to disable a specific script
            transform.GetComponent<BoxCollider>().enabled = false;
            //GameObject.FindWithTag("RightPeck").active = false;
            //RightPeck.SetActive(false);

            //this.enabled = false;
        }



    }



    void Update()
    {

    }
}
