using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Main Script that controls most of the functionality


public class CounterKidney : MonoBehaviour
{   
    //incrementable variables by other scripts
    public int chestcutter = 0;
    public int kidneycutter = 0;
    public int stichescounter = 0;
    public int leftpeck = 0;
    public int rightpeck = 0;
    public int damageTaken = 0;
    public int gutscounter = 0;

    //used for damage calculations and healthbar
    public int lastX = 0; 
    public int maxHealth = 100;
    public int currentHealth;
    public HeartBar healthBar;
    public Text textField;    

    GameObject scalpel;    
    
    void Start()
    {       
        lastX = damageTaken;
        
        //All the Texts on start are made invisible
        GameObject.Find("RemoveChestPlatesAndGutsText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ReplaceKidneysText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StichNewKidneyText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("GameCompleted").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("MainMenuSuccesful").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ResetLevelSuccesful").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("LowHealthText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("VeryLowHealthText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("SeizureText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ThrowKidneyText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("GameOverText").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("PutGutsBackInText").transform.localScale = new Vector3(0, 0, 0);

        //Select buttons made invisible
        GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("MainMenu").transform.localPosition = new Vector3(0, 0, 0);

        //Pecks made invisible and some visible
        GameObject.Find("RightPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
        GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("RightPeck2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("LeftPeck2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0, 0, 0);

        //Guts
        GameObject.Find("GutsCube").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("GutsHP2").transform.localScale = new Vector3(0, 0, 0);

        //Kidney
        GameObject.Find("CutKidneyVeins").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("StitchUpAreaKidney").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("GutsHP").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("KidneyRight2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("KidneyRightNew").transform.GetComponent<KidneySpawn>().enabled = false; //to only allow the cube spawner work after the veins are cut
        GameObject.Find("KidneyRightWithXR").transform.localPosition = new Vector3(0, 0, 0);

        //Blood Animation
        GameObject.Find("Blood1").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood1").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood2").transform.GetComponent<Animator>().enabled = false;        
        GameObject.Find("Blood2").transform.localScale = new Vector3(0, 0, 0); 
        GameObject.Find("Blood3").transform.GetComponent<Animator>().enabled = false;       
        GameObject.Find("Blood3").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood4").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood4").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood5").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood5").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood6").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood6").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood7").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood7").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood8").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood8").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood9").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood9").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Blood10").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Blood10").transform.localScale = new Vector3(0, 0, 0);

        //Other Animations
        GameObject.Find("SyringeAnimation").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("Patient").transform.GetComponent<Animator>().enabled = false;
        GameObject.Find("AdrenalineSphere").transform.localPosition = new Vector3(0, 0, 0);
        GameObject.Find("Injection").transform.localScale = new Vector3(0, 0, 0);

        //Health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);   
    }

    // Update is called once per frame
    void Update()
    { 
        //Call Functions
        CutChestOut();
        CutKidneyOut();
        StitchKidney();
        Guts();
        Chest();

        //Calculate Damage
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
        if (chestcutter == 5) //when all the pieces are triggered 53
        {
            GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RemoveChestPlatesAndGutsText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

            GameObject.Find("GutsHP").transform.localScale = new Vector3(0.4372422f, 0.4063207f, 0.4828697f);

            scalpel = GameObject.FindWithTag("SliceLine"); //chnage the scalpels tag to allow for counting for further cutting.
            scalpel.transform.gameObject.tag = "SliceVeinsTag";

            //Hide chest with no XR so you can move the correct one
            GameObject.Find("RightPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RightPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.Find("LeftPeck").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("LeftPeckWithXR").transform.localScale = new Vector3(0.001000001f, 0.0011363f, 0.001f);
            GameObject.FindWithTag("CutOutChest").active = false;
            GameObject.Find("CutKidneyVeins").transform.localScale = new Vector3(1, 1, 1); // show where to cut kidney veins
            GameObject.Find("CutOutChestTooDeep").active = false; //once the chest is cut the the too deep area will disappear       

            GameObject.Find("GutsHP").transform.localPosition = new Vector3(-1.735f, 3.442f, 2.138f);

            chestcutter = 0;
        }
    }

    void CutKidneyOut()
    {
        if (kidneycutter == 2) //when all the pieces are triggered
        {
            GameObject.Find("RemoveChestPlatesAndGutsText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("KidneyRight").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("KidneyRightWithXR").transform.localPosition = new Vector3(-1.682763f, 3.383473f, 2.0353f);

            GameObject.Find("ReplaceKidneysText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.FindWithTag("CutKidneyVeins").active = false;
            GameObject.Find("KidneyRightNew").transform.GetComponent<KidneySpawn>().enabled = true;
            kidneycutter = 0;
        }
    }

    void StitchKidney()
    {
        if (stichescounter == 5)//when all the pieces are triggered
        {                       
            GameObject.Find("StichNewKidneyText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("PutGutsBackInText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.FindWithTag("StitchUpAreaKidney").active = false;
            GameObject.Find("GutsCube").transform.localPosition = new Vector3(0.3411f, 1.155f, -3.0671f);
            stichescounter = 0;
        }
    }

    void Guts()
    {
        if(gutscounter == 1 || gutscounter == 2)
        {
            GameObject.Find("PutGutsBackInText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("GutsCube").transform.localPosition = new Vector3(0, 0, 0);
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("ChestCubeLeft").transform.localPosition = new Vector3(0.52116f, 1.23325f, -2.985f);
            GameObject.Find("ChestCubeRight").transform.localPosition = new Vector3(0.52157f, 1.23243f, -3.1456f);

            gutscounter = 0;
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
            GameObject.Find("LowHealthText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("VeryLowHealthText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0, 0, 0);

            //write well done and stop time
            GameObject.Find("Timer").transform.GetComponent<TimerControllerKidney>().enabled = false; //this needed otherwise it wouldnt spawn
            textField.fontSize = 20;
            textField.text = "Completed";
            GameObject.Find("PanicAudio").GetComponent<AudioSource>().mute = true;
            GameObject.Find("PanicAudio2").GetComponent<AudioSource>().mute = true;
            GameObject.Find("Tools").transform.localScale = new Vector3(0, 0, 0); //get rid off the tools
            GameObject.Find("DoneAudio").GetComponent<AudioSource>().mute = false;            
            GameObject.Find("DoneAudio").GetComponent<AudioSource>().loop = false;
            rightpeck = 0;
            leftpeck = 0;
        }
    }
   
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth == 40 )//Heartbeat sound
        {
            GameObject.Find("LowHealthText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("PanicAudio").GetComponent<AudioSource>().mute = false;            
        }
        else if(currentHealth == 20)//intense heart beat sound
        {
            GameObject.Find("LowHealthText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("VeryLowHealthText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("PanicAudio").GetComponent<AudioSource>().mute = true;
            GameObject.Find("PanicAudio2").GetComponent<AudioSource>().mute = false;
        }
        else if(currentHealth == 0)//GameOver
        {
            GameObject.Find("LowHealthText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("VeryLowHealthText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StartGameText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("RemoveChestPlatesAndGutsText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("ReplaceKidneysText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("StichNewKidneyText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("PutBackChestText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("HeartRate").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Heart").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("AudioSource").GetComponent<AudioSource>().mute = true;
            GameObject.Find("PanicAudio").GetComponent<AudioSource>().mute = true;
            GameObject.Find("PanicAudio2").GetComponent<AudioSource>().mute = true;
            GameObject.Find("DeadAudio").GetComponent<AudioSource>().mute = false; 
            GameObject.Find("GameOverText").transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            GameObject.Find("ExtraTimeText").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Tools").transform.localScale = new Vector3(0, 0, 0); //get rid off the tools
            GameObject.Find("ResetLevel").transform.localPosition = new Vector3(0.775f, 1.53f, -2.703f);
            GameObject.Find("MainMenu").transform.localPosition = new Vector3(00.775f, 1.53f, -3.0937f);
            GameObject.Find("AllTexts").transform.localScale = new Vector3(0, 0, 0);
            //write gameover and stop time
            GameObject.Find("Timer").transform.GetComponent<TimerControllerKidney>().enabled = false; //this needed otherwise it wouldnt spawn
            textField.fontSize = 20;
            textField.text = "GameOver";
        }
    }
}