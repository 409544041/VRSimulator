using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int counterNumber = 0;
    GameObject right;
    //public XRGrabInteractable grabInteractable;

    // Start is called before the first frame update
    void Start()
    {

        //right = GameObject.FindWithTag("RightPeck");
        // Hide button
        GameObject.Find("RightPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f); 
        GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);

        //Rigidbody gameObjectsRigidBody = right.gameObjectsRigidBody.isKinematic = true; // Set the GO's mass to 5 via the Rigidbody.


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
        if (counterNumber == 5)
        {



            GameObject.Find("RightPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);

            //Rigidbody gameObjectsRigidBody = right.AddComponent<Rigidbody>(); // Add the rigidbody.
            //gameObjectsRigidBody.isKinematic = true; // Set the GO's mass to 5 via the Rigidbody.
            //right.isKinematic = true; // Set the GO's mass to 5 via the Rigidbody.
            //grabInteractable = GetComponent<XRGrabInteractable>();




            //right.AddComponent<XRGrabInteractable>(); // Add the rigidbody.
            //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.






            //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
            counterNumber = 0;

        }
        
    }
}