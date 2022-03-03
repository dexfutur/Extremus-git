using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCaracol : MonoBehaviour
{
    public Camera camera;
    public Audio1 audio;
    /*private void OnMouseDown()
    {
        Debug.Log("El caracol se muueeveee");
        SnailNarration();
    }*/

    private void SnailNarration()
    {
        Debug.Log("Tiene un caparazón de sulfuro...");
        audio.PlaySnail();
    }
    void Update()
    {
        if (!audio.myAudio.isPlaying)
        {
            Debug.Log("Paró narración");
            ClickAction();
        }
    }
    void ClickAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray goes through camera to position in the world the mouse points
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<TargetC>() != null)
                {
                    Debug.Log("El caracol se muueeveee");
                    SnailNarration();
                }
            }
        }
    }
}
