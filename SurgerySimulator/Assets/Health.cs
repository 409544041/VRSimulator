using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private Animator myanimation;
    public Counter counterScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SliceVeinsTag")
        {
            GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn
            GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn
            GameObject.Find("Blood1").transform.localScale = new Vector3(0.0008744821f, 0.002815551f, 0.002412532f);
            GameObject.Find("Blood2").transform.localScale = new Vector3(0.0008744819f, 0.002815552f, 0.002412532f);

            counterScript.damageTaken += 1; //send damage poitns to counter script

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "SliceVeinsTag")
        {
            GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = false; //this needed otherwise it wouldnt spawn
            GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = false; ; //this needed otherwise it wouldnt spawn
            GameObject.Find("Blood1").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood2").transform.localScale = new Vector3(0, 0, 0);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
