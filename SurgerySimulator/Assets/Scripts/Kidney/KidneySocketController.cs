using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the new heart from the cooler is placed back in it respawn in the correct position

public class KidneySocketController : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HeartTrigger")
        {
            GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("HeartNew").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Heart2").transform.localScale = new Vector3(0.4000004f, 0.4000004f, 0.4000004f);
            GameObject.Find("Heart2").transform.GetComponent<Animator>().enabled = true;
            GameObject.Find("StitchUpAreaHeart").transform.localScale = new Vector3(1, 1, 1); // stitches appear after heart was placed in
        }
    }    
}
