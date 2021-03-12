using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawn : MonoBehaviour
{

    public HeartSocketController myScript;
    int var = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hands")
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(0.01f, -0.01f, 0.01f);
            cube.transform.localPosition = new Vector3(0.6089f, 1.1754f, -3.0669f);
            cube.GetComponent<Renderer>().material.color = new Color(0, 0, 255);


            //transform.GetComponent<Renderer>().material = cutLineMaterial;
            //counterScript.heartcutter += 1;
            //transform.GetComponent<BoxCollider>().enabled = false;
        }
    }*/

    void OnTriggerEnter(Collider col)
    {
        if (!enabled) return; //if the script isnt enabled it wont execute this otherwise OnTrigger is constatnly active even tho the script is diabled

        if (col.gameObject.tag == "Hands")
        {
            var += 1; //to prevent more than one cube spawning

            if (var == 1)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.localScale = new Vector3(0.01f, -0.01f, 0.01f);
                cube.transform.localPosition = new Vector3(0.6089f, 1.1754f, -3.0669f);
                cube.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
                cube.gameObject.tag = "HeartCube";
                cube.GetComponent<BoxCollider>().isTrigger = true;
                cube.gameObject.AddComponent<HeartSocketController>().enabled = true; //assign HeartSocketController onto the spawned cube
                
                //cube.transform.GetComponent<HeartSocketController>()


                //myScript.enabled = true;




                //transform.GetComponent<Renderer>().material = cutLineMaterial;
                //counterScript.heartcutter += 1;
                //transform.GetComponent<BoxCollider>().enabled = false;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
