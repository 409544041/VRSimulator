using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when the liver from the cooler is touched it spawn a cube to show the user where it has to go

public class LiverSpawn : MonoBehaviour
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
                cube.transform.localPosition = new Vector3(0.4842f, 1.13617f, -2.97167f);
                cube.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
                cube.gameObject.tag = "LiverCube";
                cube.GetComponent<BoxCollider>().isTrigger = true;
                cube.gameObject.AddComponent<LiverSocketController>().enabled = true; //assign LiverSocketController onto the spawned cube     
            }
        }
    }
}
