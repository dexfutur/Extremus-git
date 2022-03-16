using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBlobFish : MonoBehaviour
{
    public Camera camera;
    public ActiveNarrNuclear nar;
    public AudioMarino audios;
    Animator animator;
  

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void BlobNarration()
    {
        Debug.Log("Blob");
        audios.PlayBlob();
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
                    Debug.Log("Blob caminaaa");
                    animator.SetBool("semueve", true);
                    BlobNarration();
                }
            }
        }
    }
}
