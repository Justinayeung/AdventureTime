using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public Image noteImage;
    public GameObject noteHideButton;

    public AudioClip noteAudio;
    public AudioClip notePutAway;
    public AudioSource notePicked;
    public AudioSource notePutDown;
   
    void Start()
    {
        //disabling the note to appear
        noteImage.enabled = false;
        noteHideButton.SetActive(false);


}

public void ShowNoteImage()
    {
        //function for what the note will do once player interacts with it
        noteImage.enabled = true;
        noteHideButton.SetActive(true);

     notePicked.PlayOneShot(noteAudio);
    }

    public void HideNote()
    {
        //function for what the note will do once put away
        noteImage.enabled = false;
        noteHideButton.SetActive(false);

       notePutDown.PlayOneShot(notePutAway);
        Destroy(this);
    }
}
