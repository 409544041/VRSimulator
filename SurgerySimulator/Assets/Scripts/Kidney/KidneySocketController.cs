using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the new kidney from the cooler is placed back in it respawn in the correct position

public class KidneySocketController : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "KidneyTrigger")
        {
            GameObject.Find("ReplaceKidneysText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewKidneyText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("KidneyRightNew").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("KidneyRight2").transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            GameObject.Find("StitchUpAreaKidney").transform.localScale = new Vector3(1, 1, 1); // stitches appear after kidney was placed in
        }
    }    
}
