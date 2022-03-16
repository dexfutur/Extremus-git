using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    [SerializeField] GameObject backToIsles;
    public EndingScript ending;
    public bool isOut;
    public int contador;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aiuda");
        if (other.tag == "player")
        {
            Debug.Log("ayuda");
            contador++;
            backToIsles.SetActive(true);
        }

    }
   
}
