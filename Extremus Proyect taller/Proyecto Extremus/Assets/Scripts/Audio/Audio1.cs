using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class Audio1 : MonoBehaviour
{
    // public Sounds[] sounds;
    AudioSource myAudio;
    [SerializeField] AudioClip narrVol;
    [SerializeField] AudioClip narrSpider;

    public bool isYellin=false;
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.C))
        {
            myAudio.PlayOneShot(narrVol);
        }*/
        myAudio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    /*void Awake()
     {
         foreach(Sounds s in sounds)
         {
             s.myAudio=gameObject.AddComponent<AudioSource>();
             s.myAudio.clip = s.clip;
             s.myAudio.volume = s.volume;
         }

     }*/

    /*public void Play (string name)
     {
        Sounds s= Array.Find(sounds, sound => sound.name == name);
         s.myAudio.Play();
     }*/
    void Start()
    {
     
    }

    // Update is called once per frame
    

    public void PlayVolcan()
    {
        myAudio.PlayOneShot(narrVol);
        isYellin = true;
    }
    public void PlaySpider()
    {
        myAudio.PlayOneShot(narrSpider);
    }
    public void CheckSound()
    {
        if(!myAudio.isPlaying)
        {
            isYellin = false;
        }
    }
}
