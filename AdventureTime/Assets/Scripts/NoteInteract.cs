using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInteract : MonoBehaviour
{
    Note note;

    private void Start()
    {
        note = GetComponent<Note>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            note.ShowNoteImage();
        }
    }
}
