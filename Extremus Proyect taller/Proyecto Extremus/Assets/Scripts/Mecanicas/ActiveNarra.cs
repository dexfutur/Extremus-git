using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNarra : MonoBehaviour
{
    Audio1 audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here it is");
        audio.PlayVolcan();
        Debug.Log("Empieza narración");

        
    }
}
