using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSyringe : MonoBehaviour
{
    private Animator myanimation;
    public Counter counterScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Syringe")
        {
            GameObject.Find("Blood5").transform.GetComponent<Animator>().enabled = true;            
            GameObject.Find("Blood5").transform.localScale = new Vector3(0.04372412f, 0.1407776f, 0.1206266f);

            GameObject.Find("Blood6").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("Blood6").transform.localScale = new Vector3(0.04372412f, 0.1407776f, 0.1206266f);

            counterScript.damageTaken += 1; //send damage poitns to counter script

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Syringe")
        {
            GameObject.Find("Blood5").transform.GetComponent<Animator>().enabled = false;            
            GameObject.Find("Blood5").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Blood6").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Blood6").transform.localScale = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
