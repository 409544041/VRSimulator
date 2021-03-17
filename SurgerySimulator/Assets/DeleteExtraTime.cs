using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExtraTime : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HeartWithXR")
        {           
            GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("HeartWithXR").transform.localScale = new Vector3(0, 0, 0);          
        }
    }
}
