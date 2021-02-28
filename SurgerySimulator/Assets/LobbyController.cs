using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{

    [SerializeField] private string HeartSurgery;
    [SerializeField] private string KidneySurgery;
    [SerializeField] private string LiverSurgery;

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

    public void LoadKidneySurgery()
    {
        SceneManager.LoadScene(KidneySurgery);
    }

    public void LoadLiverSurgery()
    {
        SceneManager.LoadScene(LiverSurgery);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
