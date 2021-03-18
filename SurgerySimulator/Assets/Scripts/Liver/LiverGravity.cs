using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the liver is cut out and its given gravity so you can throw it in the bin for extra time

public class LiverGravity : MonoBehaviour
{    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hands")
        {            
            GameObject.Find("LiverHPWithXR").GetComponent<Rigidbody>().isKinematic = false;
            GameObject.Find("ThrowLiverText").transform.localScale = new Vector3(0.003415799f, 0.004757092f, 0.0084107f);
        }
    }
}
