﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController),typeof(playermove),typeof(playerrotate))]
public class player : MonoBehaviour
{
    private playermove _move;
    private playerrotate _rotate;
    private playerrotate rotateSmooth;
    private playerrotate currentRotate;
    private void Awake()
    {
        _move = GetComponent<playermove>();
        _rotate = GetComponents<playerrotate>()[0];
        rotateSmooth = GetComponents<playerrotate>()[1];
        currentRotate = rotateSmooth;



        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        _move.Move();
        currentRotate.Rotate();
    }
}
