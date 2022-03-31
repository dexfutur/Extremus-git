using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerrotate : MonoBehaviour

{
    [Header("PlayerRotate Properties")]
    [SerializeField] private Transform cameraHolder;
    [SerializeField] public float speed;
    [SerializeField] private float rotation_limit;
    protected float vertRot;
    public virtual void Rotate()
    {
        vertRot -= GetVerticalValue();
        vertRot = vertRot <= -rotation_limit ? -rotation_limit :
            vertRot >= rotation_limit ? rotation_limit :
            vertRot;

        RotateVertical();
        RotateHorizontal();
    }

    protected float GetVerticalValue() => Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
    protected float GetHorizontalValue() => Input.GetAxis("Mouse X") * speed * Time.deltaTime;
    protected virtual void RotateVertical() => cameraHolder.localRotation = Quaternion.Euler(vertRot, 0f, 0f);
    protected virtual void RotateHorizontal() => transform.Rotate(Vector3.up * GetHorizontalValue());


}
