using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    /*public Texture2D cursor;
    public Texture2D cursorClicked;
    private CursorControll controls;

    private Camera mainCamera;
    private void Awake()
    {
        controls = new CursorControll();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;

    }
    private void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
       // controls.Mouse.Click.performed += _ => EndedClick();
    }
    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }
    private void EndedClick()
    {
      
        DetectObject();
    }
    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        { 
            if(hit.collider!=null)
            {
                Debug.Log("3D hit : " + hit.collider.tag);
            }
           
        }
    }
   
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    private void ChangeCursor(Texture2D cursorType)
    {
        Vector2 hotspot = new Vector2(cursorType.width / 2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }*/
}
