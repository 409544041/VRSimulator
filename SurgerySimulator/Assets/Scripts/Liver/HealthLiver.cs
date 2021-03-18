using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if scalpel touched incorrect organs, if so they bleed

public class HealthLiver : MonoBehaviour
{
    private Animator myanimation;
    public CounterLiver counterScript;    

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SliceVeinsTag")
        {
            GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood1").transform.localScale = new Vector3(0.0008744821f, 0.002815551f, 0.002412532f);
            GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = true;            
            GameObject.Find("Blood2").transform.localScale = new Vector3(0.0008744819f, 0.002815552f, 0.002412532f);            
            counterScript.damageTaken += 1; //send damage poitns to counter script
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "SliceVeinsTag")
        {
            GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood1").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = false;            
            GameObject.Find("Blood2").transform.localScale = new Vector3(0, 0, 0);            
        }
    }
}
