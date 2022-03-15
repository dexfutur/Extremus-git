using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPajaro : MonoBehaviour
{
    public Camera camera;
    public Audio1 audio;
   /* private void OnMouseDown()
    {
        Debug.Log("El pájaro camina/Aletea)");
        BirdNarration();
    }*/

    private void BirdNarration()
    {
        Debug.Log("Este  párajo con grandes patas...");
        audio.PlayBird();
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
                if (hitInfo.collider.gameObject.GetComponent<TargetP>() != null)
                {
                    Debug.Log("El pájaro camina/Aletea");
                    BirdNarration();
                }
            }
        }
    }
}
