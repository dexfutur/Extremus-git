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

   /* void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }*/
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aiuda");
        if (other.tag == "player")
        {
            
            contador++;
            backToIsles.SetActive(true);
            Debug.Log("se activó");
        }
        if (gameObject.tag=="volcan")
        {
            Debug.Log("alamadre");
            isOutV = true;
        }
       else if (gameObject.tag == "marino")
        {
            Debug.Log("wepa");
            isOutM = true;
        }
        else if (gameObject.tag == "nuclear")
        {
            Debug.Log("matadme");
            isOutN = true;
        }

    }
   
}
