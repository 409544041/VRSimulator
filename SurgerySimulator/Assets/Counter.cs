using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public int chestcutter = 0;
    public int heartcutter = 0;
    public int stichescounter = 0;
    public int leftpeck = 0;
    public int rightpeck = 0;
    public int damageTaken = 0;

    
    public int lastX = 0;

    public int maxHealth = 100;
    public int currentHealth;
    public HeartBar healthBar;

    public Text textField;

    GameObject scalpel;
    //GameObject heart;


    // Start is called before the first frame update
    void Start()
    {
        lastX = damageTaken;

        GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);

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

        GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood1").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood2").transform.localScale = new Vector3(0, 0, 0);
        

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        GameObject.Find("GameOverText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("MainMenu").transform.localPosition = new Vector3(0, 0, 0);        

        GameObject.Find("GameCompleted").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("MainMenuSuccesful").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ResetLevelSuccesful").transform.localPosition = new Vector3(0, 0, 0);

        ;

    }

    // Update is called once per frame
    void Update()
    {
        CutChestOut();
        CutHeartOut();
        StitchHeart();
        Chest();

        if (damageTaken > lastX)
        {   
            TakeDamage(10);
            lastX = damageTaken;
        }
        else
        {            
            lastX = damageTaken;
        }  
    }
    

    void CutChestOut()
    {
        if (chestcutter == 5)
        {
            GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

            scalpel = GameObject.FindWithTag("SliceLine"); //chnage the scalpels tag to allow for counting for further cutting.
            scalpel.transform.gameObject.tag = "SliceVeinsTag";

            //Hide chest with no XR so yoiu can move the correct one
            GameObject.Find("RightPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.Find("LeftPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("CutOutChest").active = false;
            GameObject.Find("Heart").transform.GetComponent<Animator>().enabled = true; //this needed otherwise it wouldnt spawn
            GameObject.Find("CutHeartVeins").transform.localScale = new Vector3(1, 1, 1); // show where to cut heart veins
            GameObject.Find("CutOutChestTooDeep").active = false; //once the chest is cut the the too deep area will disappear

            

            chestcutter = 0;
        }
    }

    void CutHeartOut()
    {
        if (heartcutter == 5)
        {
            GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);


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
            
            GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);


            GameObject.FindWithTag("StitchUpHeartArea").active = false;
            GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0.5217f, 1.2367f, -2.985f);
            GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0.5217f, 1.2367f, -3.1456f);
            stichescounter = 0;
        }
    }

    void Chest()
    {
        if(rightpeck == 1 && leftpeck == 1) //game completed
        {
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("GameCompleted").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("MainMenuSuccesful").transform.localPosition = new Vector3(0.774f, 1.53f, -3.091f);
            GameObject.Find("ResetLevelSuccesful").transform.localPosition = new Vector3(0.775f, 1.53f, -2.703f);

            //write well done and stop time
            GameObject.Find("Timer").transform.GetComponent<TimerController>().enabled = false; //this needed otherwise it wouldnt spawn
            textField.fontSize = 20;
            textField.text = "Completed";
        }
    }
    

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth ==0)
        {
            GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("CutHeartOutText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ReplaceHeartsText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewHearText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);

            GameObject.Find("HeartRate").transform.localScale = new Vector3(0, 0, 0);





            GameObject.Find("GameOverText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("Tools").transform.localScale = new Vector3(0, 0, 0); //get rid off the tools
            GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0.775f, 1.53f, -2.703f);
            GameObject.Find("MainMenu").transform.localPosition = new Vector3(00.775f, 1.53f, -3.0937f);

            //write gameover and stop time
            GameObject.Find("Timer").transform.GetComponent<TimerController>().enabled = false; //this needed otherwise it wouldnt spawn
            textField.fontSize = 20;
            textField.text = "GameOver";
        }
    }


}