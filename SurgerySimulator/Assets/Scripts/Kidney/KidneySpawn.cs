using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the kidney from the cooler is touched it spawn a cube to show the user where it has to go

public class KidneySpawn : MonoBehaviour
{
    int var = 0;
    
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
                cube.transform.localPosition = new Vector3(0.383f, 1.04659f, -3.16669f);
                cube.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
                cube.gameObject.tag = "KidneyCube";
                cube.GetComponent<BoxCollider>().isTrigger = true;
                cube.gameObject.AddComponent<KidneySocketController>().enabled = true; //assign KidneySocketController onto the spawned cube     
            }
        }
    }
}
