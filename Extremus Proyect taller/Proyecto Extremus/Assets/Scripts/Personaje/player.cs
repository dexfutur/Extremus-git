using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController),typeof(playermove),typeof(playerrotate))]
public class player : MonoBehaviour
{
    private playermove _move;
    private playerrotate _rotate;

    private void Awake()
    {
        _move = GetComponent<playermove>();
        _rotate = GetComponent<playerrotate>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        _move.Move();
        _rotate.Rotate();
    }
}
