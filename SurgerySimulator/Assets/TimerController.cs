using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float startTime;

    private string textTime;

    private float guiTime;

    private int minutes;
    private int seconds;
    private int fraction;

    public Text textField;



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

        if (minutes >= 3) //after 3 minutes game over
        {
            textField.fontSize = 20;
            textField.text = "GameOver";
            GameObject.Find("HeartRate").transform.localScale = new Vector3(0, 0, 0);

            GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);

            GameObject.Find("GameOverText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("Tools").transform.localScale = new Vector3(0, 0, 0); //get rid off the tools
            GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0.775f, 1.53f, -2.703f);
            GameObject.Find("MainMenu").transform.localPosition = new Vector3(00.775f, 1.53f, -3.0937f);


            //add reset options here
        }
        else
        {
            textField.text = textTime;
        }
    }
}
