using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConteoEscenasFinal : MonoBehaviour
{

    /*static List <string> allScenes= new List<string> { "Volcánico", "Nuclear", "Marino" };

     

   private void Start()
    {
       // Object.Dontdestroyonload(GameObject);

        if (allScenes.Count > 0)
        {
            var scene=allScenes[allScenes.Count-1];
            SceneManager.LoadScene(scene);
            allScenes.Remove(scene);
        }
        else
        {
            SceneManager.LoadScene("Despedida");
        }
    }*/
    public GoToMain outScript;

     void Update()
    {
        CheckBools();
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
     void Start()
    {
       outScript= FindObjectOfType<GoToMain>();
    }

    public void CheckBools()
    {

        /*if(outScript.isOutV==true)
        {
            Debug.Log("AAAH");
        }
        else if(outScript.isOutN == true)
        {
            Debug.Log("Elizabeth Montgomery");
        }
        else if (outScript.isOutM == true)
        {
            Debug.Log("Gaara t amo");
        }*/
       /* if(outScript.isOutV==true&&outScript.isOutN==true&&outScript.isOutM==true)
        {
            Debug.Log("CUEFJAOI");
        }*/
    }
}
