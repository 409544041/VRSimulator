using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ChestSocketControllerRight : MonoBehaviour
{

    // Start is called before the first frame update
    

    public Counter counterScript;
    //GameObject countingScript;

    void Start()
    {

        //countingScript = GameObject.Find("CounterGameObject");


        //counterScript.AddComponent<countingScript>();


        //GameObject gem = GameObject.Find("CounterGameObject");
        //counterScript script = gem.AddComponent<counterScript>();
        //the script variable is now the factoryScript you added in the line above.
        //script.someParameter = someValue;

        //cube2.gameObject.AddComponent<ChestSocketControllerRight>().enabled = true;

    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.tag == "RighPeckWithXR")
        {

            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeck2").transform.localScale = new Vector3(0.001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("ChestCubeRight").transform.localScale = new Vector3(0, 0, 0);

            counterScript.rightpeck += 1;
        }
    }

    void Update()
    {

    }



    

    
}
