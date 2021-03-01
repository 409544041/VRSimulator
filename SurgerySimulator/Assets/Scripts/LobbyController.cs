using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{

    [SerializeField] private string HeartSurgeryWaitingRoom;
    [SerializeField] private string KidneySurgeryWaitingRoom;
    [SerializeField] private string LiverSurgeryWaitingRoom;

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
        SceneManager.LoadScene(HeartSurgeryWaitingRoom);
    }

    public void LoadKidneySurgery()
    {
        SceneManager.LoadScene(KidneySurgeryWaitingRoom);
    }

    public void LoadLiverSurgery()
    {
        SceneManager.LoadScene(LiverSurgeryWaitingRoom);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
