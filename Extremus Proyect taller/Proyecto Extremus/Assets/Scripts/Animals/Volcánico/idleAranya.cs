﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAranya : MonoBehaviour
{
    public Camera camera;
    public ActiveNarra nar;
    public Audio1 audios;
    public playerrotate rotateSmooth;
    public playermove _move;
    public playerrotate _rotate;
    Animator animator;
    // Audio1 audio;
    /*private void OnMouseDown()
    {
       Debug.Log("La araña camina");
        SpiderNarration();
    }*/
    //PATROL AI
    public Transform[] waypoints;
    public int speed;
    private int waypointIndex;
    private float dist;
    public bool isPatrollin;

    void Start()
    {
        animator = GetComponent<Animator>();
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
       
        isPatrollin = false;

    }
    public void LimitAction()
    {
        _move._speed = 0;
        _rotate.speed = 0;
        rotateSmooth.speed = 0;
    }
    public void AllowAction()
    {
        _move._speed = 10;
        _rotate.speed = 200;
        rotateSmooth.speed = 200;
    }
    private void SpiderNarration()
    {
        Debug.Log("Esta es la araña delas islas Kuai");
        audios.PlaySpider();
    }
     void Update()
    {
        if(!audios.myAudio.isPlaying)
        {
            Debug.Log("Paró narración");
            ClickAction();
        }
        if (dist < 1f)
        {
            IncreaseIndex();
        }
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        //con bools
        Patrol();

    }

    void Patrol()
    {
        if(isPatrollin==true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("IT MOVES");
        }
       
    }
    void DontPatrol()
    {
        transform.Translate(Vector3.forward * 0 * Time.deltaTime);
        Debug.Log("troste");
    }
    void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex>=waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
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
                    Debug.Log("La araña camina");
                    
                    animator.SetBool("semueve", true);
                  
                    SpiderNarration();
                    LimitAction();
                    Invoke("AllowAction", 18f);
                    isPatrollin = true;
                   
                }
            }
        }
    }
}

