using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAranya : MonoBehaviour
{
    private void OnMouseDown()
    {
       Debug.Log("La araña camina");
        SpiderNarration();
    }

   private void SpiderNarration()
    {
        Debug.Log("Esta que ves aquí es la araña de las cuevas....");
    }
}
