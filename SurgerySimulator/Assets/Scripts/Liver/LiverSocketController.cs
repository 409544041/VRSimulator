using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the new liver from the cooler is placed back in it respawn in the correct position

public class LiverSocketController : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "LiverTrigger")
        {
            GameObject.Find("ReplaceLiverText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewLiverText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("LiverHPNew").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LiverHP2").transform.localScale = new Vector3(0.3000002f, 0.3000002f, 0.3000002f);            
            GameObject.Find("StitchUpAreaLiver").transform.localScale = new Vector3(1, 1, 1); // stitches appear after liver was placed in
        }
    }    
}
