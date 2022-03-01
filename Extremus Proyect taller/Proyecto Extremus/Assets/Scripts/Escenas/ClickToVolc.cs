using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToVolc : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Volcánico");
    }
}
