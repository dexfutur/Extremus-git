using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here it is");
        if (other.tag == "player")
        {
            SceneManager.LoadScene("Islas");
        }

    }
    
}
