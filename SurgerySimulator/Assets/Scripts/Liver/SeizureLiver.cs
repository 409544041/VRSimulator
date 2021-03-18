using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//the syringe has to trigger the sphere to stop the seizure otherwise the player looses

public class SeizureLiver : MonoBehaviour
{
    public TimerControllerLiver timeScript;

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
}
