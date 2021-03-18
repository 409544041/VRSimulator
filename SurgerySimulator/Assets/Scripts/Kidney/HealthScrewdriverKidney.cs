using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if screwdriver touched incorrect organs, if so they bleed

public class HealthScrewdriverKidney : MonoBehaviour
{
    private Animator myanimation;
    public CounterKidney counterScript;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Screwdriver")
        {
            GameObject.Find("Blood9").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood10").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood9").transform.localScale = new Vector3(0.0305464f, 0.09834959f, 0.08427179f);
            GameObject.Find("Blood10").transform.localScale = new Vector3(0.0305464f, 0.09834959f, 0.08427179f);
            counterScript.damageTaken += 1; //send damage poitns to counter script
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Screwdriver")
        {
            GameObject.Find("Blood9").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood10").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood9").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood10").transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
