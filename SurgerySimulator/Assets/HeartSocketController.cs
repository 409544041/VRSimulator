using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSocketController : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HeartTrigger")
        {

            //GameObject.Find("Testing").transform.localPosition = new Vector3(0.6089f, 1.1754f, -3.0669f);
            GameObject.Find("HeartNew").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Heart2").transform.localScale = new Vector3(0.4000004f, 0.4000004f, 0.4000004f);
            GameObject.Find("Heart2").transform.GetComponent<Animator>().enabled = true;

            GameObject.Find("StitchUpAreaHeart").transform.localScale = new Vector3(1, 1, 1); // stitches appear after heart was placed in



            //Debug.Log("Hello from the heart");
            //transform.GetComponent<Renderer>().material = cutLineMaterial;
            //counterScript.heartcutter += 1;
            //transform.GetComponent<BoxCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
