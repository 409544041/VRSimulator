using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if needle touched incorrect organs, if so they bleed

public class HealthNeedle : MonoBehaviour
{
    private Animator myanimation;
    public Counter counterScript;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Needle")
        {
            GameObject.Find("Blood3").transform.GetComponent<Animator>().enabled = true; 
            GameObject.Find("Blood4").transform.GetComponent<Animator>().enabled = true; 
            GameObject.Find("Blood3").transform.localScale = new Vector3(0.0008744821f, 0.002815551f, 0.002412532f);
            GameObject.Find("Blood4").transform.localScale = new Vector3(0.0008744819f, 0.002815552f, 0.002412532f);
            counterScript.damageTaken += 1; //send damage poitns to counter script
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Needle")
        {
            GameObject.Find("Blood3").transform.GetComponent<Animator>().enabled = false; 
            GameObject.Find("Blood4").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood3").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood4").transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
