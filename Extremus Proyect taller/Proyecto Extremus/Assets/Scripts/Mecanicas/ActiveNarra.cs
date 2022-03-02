using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNarra : MonoBehaviour
{
    public Audio1 audio;
    public bool isTalking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolcNarr()
    {
        isTalking = true;
        Debug.Log("Empieza Narración");
        audio.PlayVolcan();

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here it is");

        VolcNarr();
        isTalking = false;
        
    }
}
