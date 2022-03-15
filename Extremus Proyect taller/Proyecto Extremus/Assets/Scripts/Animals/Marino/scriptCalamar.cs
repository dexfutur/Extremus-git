using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCalamar : MonoBehaviour
{
    public Camera camera;
    public ActiveNarrNuclear nar;
    public AudioMarino audios;

    void Start()
    {

    }
    private void SquidNarration()
    {
        Debug.Log("Calamar");
        audios.PlayCalamar();
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
                if (hitInfo.collider.gameObject.GetComponent<TargetA>() != null)
                {
                    Debug.Log("Calamar camina");
                    SquidNarration();
                }
            }
        }
    }
}
