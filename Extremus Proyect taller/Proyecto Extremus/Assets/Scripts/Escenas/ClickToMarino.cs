﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToMarino : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Marino");
    }
}
