﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int chestcutter = 0;
    public int heartcutter = 0;
    public int stichescounter = 0;
    public int leftpeck = 0;
    public int rightpeck = 0;

    GameObject scalpel;
    //GameObject heart;


    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("RightPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0);

        GameObject.Find("CutHeartVeins").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StitchUpAreaHeart").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("HeartWithXR").transform.localPosition = new Vector3(0, 0, 0);

        GameObject.Find("Heart2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("HeartNew").transform.GetComponent<HeartSpawn>().enabled = false; //to only allow the cube spawner work after the veins are cut

        GameObject.Find("RightPeck2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck2").transform.localScale = new Vector3(0, 0, 0);

        GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0, 0, 0);



    }

    // Update is called once per frame
    void Update()
    {


        CutChestOut();
        CutHeartOut();
        StitchHeart();
        Chest();

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

            chestcutter = 0;

        }

    }

    void CutHeartOut()
    {
        if (heartcutter == 5)
        {


            GameObject.FindWithTag("CutHeartVeins").active = false;

            GameObject.Find("Heart").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Heart").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("HeartWithXR").transform.localPosition = new Vector3(-1.472001f, 3.51f, 2.1214f);
            GameObject.Find("HeartWithXR").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn



            GameObject.Find("HeartNew").transform.GetComponent<HeartSpawn>().enabled = true;

            heartcutter = 0;

        }
    }

    void StitchHeart()
    {
        if (stichescounter == 5)
        {
            GameObject.FindWithTag("StitchUpHeartArea").active = false;

            /*GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube1.transform.localScale = new Vector3(0.03f, 0.005f, 0.03f);
            cube1.transform.localPosition = new Vector3(0.5065f, 1.2367f, -3.0067f);
            cube1.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            cube1.gameObject.tag = "ChestCubeLeft";
            cube1.GetComponent<BoxCollider>().isTrigger = true;
            cube1.gameObject.AddComponent<ChestSocketControllerLeft>().enabled = true;

            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(0.03f, 0.005f, 0.03f);
            cube2.transform.localPosition = new Vector3(0.5065f, 1.2367f, -3.1332f);
            cube2.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            cube2.gameObject.tag = "ChestCubeRight";
            cube2.GetComponent<BoxCollider>().isTrigger = true;
            cube2.gameObject.AddComponent<ChestSocketControllerRight>().enabled = true;*/


            GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0.5217f, 1.2367f, -2.985f);
            GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0.5217f, 1.2367f, -3.1456f);

            stichescounter = 0;

        }
    }

    void Chest()
    {
        if(rightpeck == 1 && leftpeck == 1)
        {

            //Debug.Log("chest is in place");
        }




    }



}