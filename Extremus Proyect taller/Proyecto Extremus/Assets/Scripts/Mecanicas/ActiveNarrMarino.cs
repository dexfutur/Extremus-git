using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNarrMarino : MonoBehaviour
{
    public AudioMarino audio;
    public bool isTalking;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MarNarr()
    {
        isTalking = true;
        Debug.Log("Empieza Narración Marino");
        audio.PlayMarino();

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here it is");

        MarNarr();
        isTalking = false;

    }
}
