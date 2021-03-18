using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check if hammer touched incorrect organs, if so they bleed

public class HealthHammerLiver : MonoBehaviour
{
    private Animator myanimation;
    public CounterLiver counterScript;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hammer")
        {
            GameObject.Find("Blood7").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood8").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood7").transform.localScale = new Vector3(0.02042609f, 0.0657655f, 0.05635179f);
            GameObject.Find("Blood8").transform.localScale = new Vector3(0.02042609f, 0.0657655f, 0.05635179f);
            counterScript.damageTaken += 1; //send damage poitns to counter script
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Hammer")
        {
            GameObject.Find("Blood7").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood8").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood7").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood8").transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
