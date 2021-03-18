﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Back to Lobby

public class GameOverBackToMainMenu : MonoBehaviour
{
    [SerializeField] private string MainLobby;    

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Picker")
        {
            SceneManager.LoadScene(MainLobby);
        }
    }
}