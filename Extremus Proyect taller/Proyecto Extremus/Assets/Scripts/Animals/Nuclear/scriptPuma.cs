using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPuma : MonoBehaviour
{
    public Camera camera;
    public ActiveNarrNuclear nar;
    public AudioNucl audios;
    Animator animator;
    // Audio1 audio;
    /*private void OnMouseDown()
    {
       Debug.Log("La araña camina");
        SpiderNarration();
    }*/

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void PumaNarration()
    {
        Debug.Log("PUMA");
        audios.PlayPuma();
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
                    Debug.Log("el puma camina");
                    animator.SetBool("semueve", true);
                    PumaNarration();
                }
                
            }
        }

        //Invoke("StopAnimation", 20);
    }

    public void StopAnimation()
    {
        animator.SetBool("semueve", false);

    }
}
