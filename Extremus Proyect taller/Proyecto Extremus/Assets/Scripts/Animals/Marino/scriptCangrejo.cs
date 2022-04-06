using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptCangrejo : MonoBehaviour
{
    public Camera camera;
    public ActiveNarrMarino nar;
    public AudioMarino audios;

    //Imagen En Pantalla
    public Image slot;
    public Sprite img;
    [SerializeField]
    float tiempoDesaparicion = 10f;

    Animator animator;

    void Start()
    {
      animator = GetComponent<Animator>();
    }
  
    private void CrabNarration()
    {
        Debug.Log("Cangrejo");
        audios.PlayCangrejo();
    }
    void Update()
    {
        if (!audios.myAudio.isPlaying)
        {
            Debug.Log("Paró narración");
            ClickAction();
        }



    }

    //Funcion al hacer click al animal
    public void ClickAction()
    {
        if (Input.GetMouseButtonDown(0) && !animator.GetBool("semueve"))
        {
            //Ray goes through camera to position in the world the mouse points
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {  
                if (hitInfo.collider.gameObject.GetComponent<TargetP>() != null)
                {
                    Debug.Log("el cangrejo camina");
                    animator.SetBool("semueve", true);
                    CrabNarration();

                    //Se asigna la imagen del animal y se pone el alpha en su maximo
                    slot.sprite = img;
                    Color clr = slot.color;
                    clr.a = 255f;
                    slot.color = clr;
                    //Funcion para limpiar el slot de la imagen despues de [tiempoDesaparicion] segudos
                    Invoke("ClearImage", tiempoDesaparicion);
                }
                
            }
        }
    }
            
    void ClearImage()
    {
        //Quita la referencia a la imagen y pone el aplha en su minimo
        slot.sprite =  null;
        Color clr = slot.color;
        clr.a = 0f;
        slot.color = clr;
    }
    
}
