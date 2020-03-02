using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public Image noteImage;

    public AudioClip noteAudio;
    public AudioClip notePutAway;
    void Start()
    {
        //disabling the note to appear
        noteImage.enabled = false;
       
    }

    public void ShowNoteImage()
    {
        //function for what the note will do once player interacts with it
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(noteAudio);
    }

    public void HideNote()
    {
        //function for what the note will do once put away
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(notePutAway);
    }
}
