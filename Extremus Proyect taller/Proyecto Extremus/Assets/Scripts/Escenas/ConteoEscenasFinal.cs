using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConteoEscenasFinal : MonoBehaviour
{
   
    static List <string> allScenes= new List<string> { "Volcánico", "Nuclear", "Marino" };
    

    private void Start()
    {

        if(allScenes.Count > 0)
        {
            var scene=allScenes[allScenes.Count-1];
            SceneManager.LoadScene(scene);
            allScenes.Remove(scene);
        }
        else
        {
            SceneManager.LoadScene("Despedida");
        }
    }
}
