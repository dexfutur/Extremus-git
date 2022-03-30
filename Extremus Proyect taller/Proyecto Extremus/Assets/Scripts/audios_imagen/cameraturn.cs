using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraturn : MonoBehaviour
{
    public Transform target;
    public float speed=1f, duration=19.064f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ApagarCamara", duration);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void ApagarCamara()
    {
        gameObject.SetActive(false);
    }
}
