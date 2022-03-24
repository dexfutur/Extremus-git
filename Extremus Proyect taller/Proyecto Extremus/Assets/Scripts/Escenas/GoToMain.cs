using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMain : MonoBehaviour
{
    [SerializeField] GameObject backToIsles;
    public EndingScript ending;
    public bool isOutV, isOutN, isOutM;
    public int contador;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aiuda");
        if (other.tag == "player")
        {
            
            contador++;
            backToIsles.SetActive(true);
            Debug.Log("se activó");
        }
        if (this.tag=="volcan")
        {
            Debug.Log("alamadre");
        }

    }
   
}
