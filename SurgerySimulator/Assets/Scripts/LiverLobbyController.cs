using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiverLobbyController : MonoBehaviour
{

    [SerializeField] private string LiverSurgery;
    [SerializeField] private string MainLobby;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLiverSurgery()
    {
        SceneManager.LoadScene(LiverSurgery);
    }

    public void LoadMainLobby()
    {
        SceneManager.LoadScene(MainLobby);
    }
}
