using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Play again

public class GameOverHeartRestartLiver : MonoBehaviour
{
    [SerializeField] private string LiverSurgery;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Picker")
        {
            SceneManager.LoadScene(LiverSurgery);
        }
    }

    
}
