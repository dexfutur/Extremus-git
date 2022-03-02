using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPajaro : MonoBehaviour
{
    public Camera camera;
   /* private void OnMouseDown()
    {
        Debug.Log("El pájaro camina/Aletea)");
        BirdNarration();
    }*/

    private void BirdNarration()
    {
        Debug.Log("Este  párajo con grandes patas...");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray goes through camera to position in the world the mouse points
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<TargetP>() != null)
                {
                   Debug.Log("El pájaro camina/Aletea");
                    BirdNarration();
                }
            }
        }
    }
}
