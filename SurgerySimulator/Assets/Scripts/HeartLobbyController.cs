using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartLobbyController : MonoBehaviour
{

    [SerializeField] private string HeartSurgery;
    [SerializeField] private string MainLobby;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadHeartSurgery()
    {
        SceneManager.LoadScene(HeartSurgery);
    }

    public void LoadMainLobby()
    {
        SceneManager.LoadScene(MainLobby);
    }
}
