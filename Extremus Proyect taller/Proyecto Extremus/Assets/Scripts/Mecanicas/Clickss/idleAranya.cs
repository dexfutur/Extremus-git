using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAranya : MonoBehaviour
{
    public Camera camera;
    public Audio1 audio;
    /*private void OnMouseDown()
    {
       Debug.Log("La araña camina");
        SpiderNarration();
    }*/

   private void SpiderNarration()
    {
        if(audio.isYellin==false)
        {
            audio.PlaySpider();
        }
       
    }
     void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Ray goes through camera to position in the world the mouse points
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out RaycastHit hitInfo))
            {
                if(hitInfo.collider.gameObject.GetComponent<TargetA>()!=null)
                {
                    Debug.Log("La araña camina");
                    SpiderNarration();
                }
            }
        }
    }
}
