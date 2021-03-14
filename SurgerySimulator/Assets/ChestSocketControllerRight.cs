using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSocketControllerRight : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "RighPeckWithXR")
        {

            //GameObject.Find("Testing").transform.localPosition = new Vector3(0.6089f, 1.1754f, -3.0669f);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("ChestCubeRight").transform.localScale = new Vector3(0, 0, 0);






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
