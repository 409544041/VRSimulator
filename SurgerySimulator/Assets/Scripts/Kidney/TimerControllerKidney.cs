﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControllerKidney : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float guiTime;

    private int minutes;
    private int seconds;
    private int fraction;

    public Text textField;

    public int randomCheck = 0;
    public int extraTime = 0;
    int var = 0;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        guiTime = Time.time - startTime; //guitime is the difference between the actual time and the start time
        minutes = (int)guiTime / 60; //divide the guitime by 60 for minutes
        seconds = (int)guiTime % 60; //mod for seconds
        fraction = (int)(guiTime * 100) % 100;
        textTime = string.Format("{0:00}:{1:00}", minutes, seconds, fraction);
        //text.time is what is displayed
        textField.text = textTime;        

        if (minutes >= 1 && seconds >= 5) //start seizure 
        {
            if(var == 0)
            {
                GameObject.Find("Patient").transform.GetComponent<Animator>().enabled = true; //patient having a seizure
                GameObject.Find("SeizureText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                GameObject.Find("AllTexts").transform.localScale = new Vector3(0, 0, 0);
                GameObject.Find("AdrenalineSphere").transform.localPosition = new Vector3(0.4925f, 1.0089f, -3.4352f);
                GameObject.Find("Injection").transform.localScale = new Vector3(1, 1, 1);
            }
            var += 1; // to make sure seizure happens once
        }        

        if (minutes >= 1 && seconds >= 25) // check if adrenaline given to stop seizure
        {
            if (randomCheck == 0)//if syringe not used than gameover
            {
                GameOver();
                GameObject.Find("Patient").transform.GetComponent<Animator>().enabled = false;
                GameObject.Find("SeizureText").transform.localScale = new Vector3(0, 0, 0);
                GameObject.Find("AdrenalineSphere").transform.localPosition = new Vector3(0, 0, 0);
                GameObject.Find("AllTexts").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("Injection").transform.localScale = new Vector3(0, 0, 0);
            }
            else //not gameover
            {
                GameObject.Find("Patient").transform.GetComponent<Animator>().enabled = false;
                GameObject.Find("SeizureText").transform.localScale = new Vector3(0, 0, 0);                
                GameObject.Find("AllTexts").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("Injection").transform.localScale = new Vector3(0, 0, 0);
            }
        }

        if(minutes >= 3)//time up with no extra time
        {            
            if(extraTime == 0)//if heart wasnt throw into the bin then there is no extra time so the game ends after 3mins
            {
                GameOver();
                GameObject.Find("SeizureText").transform.localScale = new Vector3(0, 0, 0);
            }            
        }

        if (minutes >= 3 && seconds >= 20)//time up with extra time +20s
        {
            if (extraTime == 1 ) //heart was thrown into the bin so the game ends with extra 20 seconds
            {
                GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0, 0, 0);
                GameOver();
                GameObject.Find("SeizureText").transform.localScale = new Vector3(0, 0, 0);
            }
        }
        else
        {
            textField.text = textTime;
        }

    }    

    void GameOver()
    {
        textField.fontSize = 20;
        textField.text = "GameOver";
        GameObject.Find("HeartRate").transform.localScale = new Vector3(0, 0, 0);       

        //deactivate script not to allow extra 20 seconds to appear
        GameObject.Find("HeartWithXR").transform.GetComponent<HeartGravity>().enabled = false;

        GameObject.Find("LowHealthText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("VeryLowHealthText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);

        GameObject.Find("GameOverText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        GameObject.Find("Tools").transform.localScale = new Vector3(0, 0, 0); //get rid off the tools
        GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0.775f, 1.53f, -2.703f);
        GameObject.Find("MainMenu").transform.localPosition = new Vector3(00.775f, 1.53f, -3.0937f);

        GameObject.Find("ThrowHeartText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Heart2").transform.GetComponent<Animator>().enabled = false;

        //to prevent continuation of the level
        GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.FindWithTag("HeartCube").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ExtraTimeCube").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("HeartNew").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("CutoutArea").transform.localPosition = new Vector3(0, 0, 0);

        //Audio
        GameObject.Find("AudioSource").GetComponent<AudioSource>().mute = true;
        GameObject.Find("PanicAudio").GetComponent<AudioSource>().mute = true;
        GameObject.Find("PanicAudio2").GetComponent<AudioSource>().mute = true;
        GameObject.Find("DeadAudio").GetComponent<AudioSource>().mute = false;
    }
}
