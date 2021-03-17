using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hands")
        {
            GameObject.Find("HeartWithXR").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("HeartWithXR").GetComponent<Rigidbody>().isKinematic = false;
            GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0.003415799f, 0.004757092f, 0.0084107f);




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
