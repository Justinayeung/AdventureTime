using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCollide : MonoBehaviour
{
    public DialogueTrigger trigger;
    public GameObject Dialogue;
    private bool isShown = false;


    //private void Start()
    //{
    //    Dialogue.SetActive(false);
    //}

    //private void Update()
    //{
    //    if (isShown)
    //    {
    //        return;
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isShown = true;
            Dialogue.SetActive(true);
            trigger.TriggerDialogue();
            Debug.Log("a convo");
        }
    }

    //public void Continue()
    //{
    //    Dialogue.SetActive(false);
    //}
}
