using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCaracol : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("El caracol se muueeveee");
        SnailNarration();
    }

    private void SnailNarration()
    {
        Debug.Log("Tiene un caparazón de sulfuro...");
    }
}
