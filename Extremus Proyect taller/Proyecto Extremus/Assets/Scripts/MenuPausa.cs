using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menupausa;     
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menupausa.SetActive(true);
        
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menupausa.SetActive(false);
    }
    public void cerrar()
    {
        Application.Quit();
    }
}
