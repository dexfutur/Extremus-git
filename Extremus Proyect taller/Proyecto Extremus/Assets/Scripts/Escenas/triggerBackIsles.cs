﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class triggerBackIsles : MonoBehaviour
{
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
        SceneManager.LoadScene("Islas");
    }
    public void Bye()
    {
        SceneManager.LoadScene("Islas");
    }
}
