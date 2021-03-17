using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Seizure : MonoBehaviour
{

    public TimerController timeScript;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Syringe")
        {
            
            timeScript.randomCheck += 1;
            GameObject.Find("SyringeAnimation").transform.GetComponent<Animator>().enabled = true;
            transform.GetComponent<SphereCollider>().enabled = false;
            
        }



    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Syringe")
        {
            GameObject.Find("SyringeAnimation").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("AdrenalineSphere").transform.localPosition = new Vector3(0, 0, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
