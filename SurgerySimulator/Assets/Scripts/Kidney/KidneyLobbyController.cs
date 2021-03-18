using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KidneyLobbyController : MonoBehaviour
{

    [SerializeField] private string KidneySurgery;
    [SerializeField] private string MainLobby;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadKidneySurgery()
    {
        SceneManager.LoadScene(KidneySurgery);
    }

    public void LoadMainLobby()
    {
        SceneManager.LoadScene(MainLobby);
    }
}
