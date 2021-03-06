using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int counterNumber = 0;
    GameObject right;

    // Start is called before the first frame update
    void Start()
    {

        right = GameObject.FindWithTag("RighPeckWithXR");

        //GameObject.FindWithTag("RighPeckWithXR").active = false;
        //transform.GetComponent<BoxCollider>().enabled = false;
        //transform.GetComponent<right>().enabled = false;
        //transform.right.enabled = false;
        //transform.GetComponent<RigidBody>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        DeactivatePrefabs();

        

    }

    void DeactivatePrefabs()
    {
        if (counterNumber == 10)
        {
            //transform.GetComponent<BoxCollider>().enabled = true;
            //GameObject.FindWithTag("RighPeckWithXR").active = true;
            //GameObject.FindWithTag("RightPeck").active = false;
            counterNumber = 0;

        }
        
    }
}
