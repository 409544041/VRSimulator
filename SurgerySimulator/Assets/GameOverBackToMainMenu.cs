using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBackToMainMenu : MonoBehaviour
{
    [SerializeField] private string MainLobby;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Test")
        {
            SceneManager.LoadScene(MainLobby);
        }
    }
}
