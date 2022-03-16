using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCucaracha : MonoBehaviour
{
    public Camera camera;
    public ActiveNarrNuclear nar;
    public AudioNucl audios;
  


    void Start()
    {
      
    }
    private void RoachNarration()
    {
        Debug.Log("PUMA");
        audios.PlayC();
    }
    void Update()
    {
        if (!audios.myAudio.isPlaying)
        {
            Debug.Log("Paró narración");
            ClickAction();
        }



    }

    public void ClickAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray goes through camera to position in the world the mouse points
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<TargetC>() != null)
                {
                    Debug.Log("la cucaracah camina");
                   
                   RoachNarration();
                }

            }
        }

      
    }

   
}
