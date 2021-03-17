using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BonusTime : MonoBehaviour
{


    public TimerController timeScript;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HeartWithXR")
        {

            timeScript.extraTime += 1;
            transform.GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("HeartWithXR").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0.001799886f, 0.002506654f, 0.00443185f);//show +10s

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
