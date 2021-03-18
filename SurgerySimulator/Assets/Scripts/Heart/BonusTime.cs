using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//collider attached to a cube inside the bin to check if the thrown heart collides with it, if it does then it increments the extraTime variable in the TimeController Script

public class BonusTime : MonoBehaviour
{
    public TimerController timeScript; //calls the TimeController Script

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HeartWithXR")
        {
            timeScript.extraTime += 1; //increments extraTime varible in the TimeController Script by 1 to tell it that its done
            transform.GetComponent<BoxCollider>().enabled = false; // turns off BoxCollider to only register the first collsion
            GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0, 0, 0); //on collide the message disappears
            GameObject.Find("HeartWithXR").transform.localScale = new Vector3(0, 0, 0); //on collide the thrown heart disappears
            GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0.001799886f, 0.002506654f, 0.00443185f);//show +10s

        }
    }
}
