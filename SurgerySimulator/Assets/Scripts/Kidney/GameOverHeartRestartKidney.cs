using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Play again

public class GameOverHeartRestartKidney : MonoBehaviour
{
    [SerializeField] private string HeartSurgery;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Picker")
        {
            SceneManager.LoadScene(HeartSurgery);
        }
    }

    
}
