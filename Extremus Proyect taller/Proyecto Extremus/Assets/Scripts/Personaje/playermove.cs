using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private CharacterController _player;
    private Vector3 _moveDir;

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
    }
}
