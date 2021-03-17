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
            transform.GetComponent<SphereCollider>().enabled = false;
            
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
