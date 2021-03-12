using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int chestcutter = 0;
    public int heartcutter = 0;

    GameObject scalpel;
    //GameObject heart;
    

    // Start is called before the first frame update
    void Start()
    {
        
        //right = GameObject.FindWithTag("RightPeck");
        // Hide peck with XR until the chest is cut
        GameObject.Find("RightPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f); 
        GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        //GameObject.Find("Organs").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("CutHeartVeins").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("HeartWithXR").transform.localPosition = new Vector3(0, 0, 0);

        GameObject.Find("Heart2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("HeartNew").transform.GetComponent<HeartSpawn>().enabled = false; //to only allow the cube spawner work after the veins are cut





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





        CutChestOut();
        CutHeartOut();



    }

    void CutChestOut()
    {
        if (chestcutter == 5)
        {

            scalpel = GameObject.FindWithTag("SliceLine"); //chnage the scalpels tag to allow for counting for further cutting.
            scalpel.transform.gameObject.tag = "SliceVeinsTag";


            //Hide cehst with no XR so yoiu can move the correct one
            GameObject.Find("RightPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.Find("LeftPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("CutOutChest").active = false;
            //GameObject.Find("Organs").transform.localScale = new Vector3(999.9996f, 999.9998f, 999.9998f);
            GameObject.Find("Heart").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn
            GameObject.Find("CutHeartVeins").transform.localScale = new Vector3(1, 1, 1); // show where to cut heart veins
            




            //Rigidbody gameObjectsRigidBody = right.AddComponent<Rigidbody>(); // Add the rigidbody.
            //gameObjectsRigidBody.isKinematic = true; // Set the GO's mass to 5 via the Rigidbody.
            //right.isKinematic = true; // Set the GO's mass to 5 via the Rigidbody.
            //grabInteractable = GetComponent<XRGrabInteractable>();




            //right.AddComponent<XRGrabInteractable>(); // Add the rigidbody.
            //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.






            //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
            chestcutter = 0;

        }
        
    }

    void CutHeartOut()
    {
        if (heartcutter == 5)
        {


            GameObject.FindWithTag("CutHeartVeins").active = false;
            //scalpel = GameObject.FindWithTag("SliceLine"); //chnage the scalpels tag to allow for counting for further cutting.
            //scalpel.transform.gameObject.tag = "SliceVeinsTag";
            

            GameObject.Find("Heart").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Heart").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("HeartWithXR").transform.localPosition = new Vector3(-1.472001f, 3.51f, 2.1214f);
            GameObject.Find("HeartWithXR").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn



            GameObject.Find("HeartNew").transform.GetComponent<HeartSpawn>().enabled = true;








            heartcutter = 0;

        }
    }
}