using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Configuracion : MonoBehaviour
{
    public void LoadScene(string scenemane)
    {
        SceneManager.LoadScene(scenemane); 
    }
}
