﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image SoundOnIcon;
    [SerializeField] Image SoundOffIcon;
    private bool muted=false;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        Updatebutton();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = true;
        }
        save();
        Updatebutton();
    }
    private void Updatebutton()
    {
        if (muted == false)
        {
            SoundOnIcon.enabled = true;
            SoundOffIcon.enabled = false;
        }
        else
        {
            SoundOnIcon.enabled = false;
            SoundOffIcon.enabled = true;
        }
    } 

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
    
}
