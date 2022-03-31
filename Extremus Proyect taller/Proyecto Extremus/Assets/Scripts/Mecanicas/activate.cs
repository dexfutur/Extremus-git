using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{
    [SerializeField] GameObject [] activations;
    public playermove playermove;
    public playerrotate playerrotate;
    public PlayerRotateSmooth playerSmooth;
    float timer;
   //El usuario llega a la isla y los primeros mensajes estarán activados
   //Primero se muestra un mensaje de introducción, a los 7 segundos pasa a otro texto
   //es enseñarle a como usar wasd
   //enseñarle a rotar
   //a clickear una rata
   //listo
    // Start is called before the first frame update
    void Start()
    {
        playermove._speed = 0;
        playerrotate.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        ShowFirstText();
      
        // Debug.Log("tIMR :" + timer);
    }

    void OnTriggerEnter(Collider other)
    {
       // ShowFirstText();
    }
    void ShowFirstText()
    {
        activations[0].SetActive(true);
        if (timer > 5)
        {
           
            activations[0].SetActive(false);
            activations[1].SetActive(true);

            if (timer >= 8)
            {
                activations[1].SetActive(false);
                playermove._speed = 10;
            }

        }
    }
    void HideFirstText()
    {

    }

    void ShowSecondText()
    {
        activations[1].SetActive(true);
        if (Time.deltaTime >= 5.0f)
        {
            Destroy(activations[1]);
        }
    }

    
}
