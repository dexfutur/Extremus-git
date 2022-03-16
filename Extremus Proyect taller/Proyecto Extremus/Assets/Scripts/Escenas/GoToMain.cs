using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    [SerializeField] GameObject backToIsles;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aiuda");
        if (other.tag == "player")
        {
            Debug.Log("ayuda");
            backToIsles.SetActive(true);
        }

    }
    
}
