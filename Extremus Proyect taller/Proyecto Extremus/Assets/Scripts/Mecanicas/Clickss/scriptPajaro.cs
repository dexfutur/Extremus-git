using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPajaro : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("El pájaro camina/Aletea)");
        BirdNarration();
    }

    private void BirdNarration()
    {
        Debug.Log("Este  párajo con grandes patas...");
    }
}
