using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collider attached to big cube to detect if the liver fell on the ground

public class DeleteExtraTimeLiver : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "LiverHPWithXR")
        {           
            GameObject.Find("ThrowLiverText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LiverHPWithXR").transform.localScale = new Vector3(0, 0, 0);          
        }
    }
}
