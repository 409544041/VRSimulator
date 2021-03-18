using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Play again

public class GameOverHeartRestartKidney : MonoBehaviour
{
    [SerializeField] private string KidneySurgery;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Picker")
        {
            SceneManager.LoadScene(KidneySurgery);
        }
    }

    
}
