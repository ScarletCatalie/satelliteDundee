using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texttrigger : MonoBehaviour {

   
    public AudioClip SoundToPlay;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public Text dialogue;
    public string text;

    //Grab Audio
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    
    void OnTriggerEnter(Collider Col)
    {

        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay);
            alreadyPlayed = true;
        }

        dialogue.text = text;
        Destroy(this.gameObject);


    }

}
