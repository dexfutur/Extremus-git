using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    [SerializeField] GameObject backToIsles;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here it is");
        if (other.tag == "player")
        {
            backToIsles.SetActive(true);
        }

    }
    
}
