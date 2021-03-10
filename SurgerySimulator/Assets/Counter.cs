using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int counterNumber = 0;
    //GameObject right;
    

    // Start is called before the first frame update
    void Start()
    {

        //right = GameObject.FindWithTag("RightPeck");
        // Hide peck with XR until the chest is cut
        /*GameObject.Find("RightPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f); 
        GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Organs").transform.localScale = new Vector3(0, 0, 0);*/

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


            //Hide cehst with no XR so yoiu can move the correct one
            /*GameObject.Find("RightPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.Find("LeftPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("CutOutArea").active = false;
            GameObject.Find("Organs").transform.localScale = new Vector3(999.9996f, 999.9998f, 999.9998f);*/



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