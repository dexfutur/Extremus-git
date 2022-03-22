using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private CharacterController _player;
    private Vector3 _moveDir;
    public AudioSource pasos;
    private bool Hactivo;
    private bool Vactivo;

    private void Awake()
    {
        _player = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if(_player.isGrounded&&_moveDir.y<0)
        {
            _moveDir.y = 0;
        }

    }
    public void Move()
    {
        _moveDir = ((transform.right * Input.GetAxis("Horizontal"))+(transform.forward*Input.GetAxis("Vertical")))*_speed;
        _moveDir.y += -9.8f;
        _player.Move(_moveDir * Time.deltaTime);

        if (Input.GetButtonDown("Horizontal"))
        {
            Hactivo = true;
            pasos.Play();
        }

        if (Input.GetButtonDown("Vertical"))
        {
            Vactivo = true;
            pasos.Play();
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            Hactivo = false;

            if (Vactivo == false)
            {
                pasos.Pause();
            }
        }

        if (Input.GetButtonUp("Vertical"))
        {
            Vactivo = false;

            if (Hactivo == false)
            {
                pasos.Pause();
            }
        }
    }
}
