using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the heart is cut out and its given gravity so you can throw it in the bin for extra time

public class KidneyGravity : MonoBehaviour
{    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hands")
        {
            GameObject.Find("HeartWithXR").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("HeartWithXR").GetComponent<Rigidbody>().isKinematic = false;
            GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0.003415799f, 0.004757092f, 0.0084107f);
        }
    }
}
