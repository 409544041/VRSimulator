using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collider attached to big cube to detect if the kidney fell on the ground

public class DeleteExtraTimeKidney : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "KidneyWithXR")
        {           
            GameObject.Find("ThrowKidneyText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.FindWithTag("KidneyWithXR").transform.localScale = new Vector3(0, 0, 0);          
        }
    }
}
