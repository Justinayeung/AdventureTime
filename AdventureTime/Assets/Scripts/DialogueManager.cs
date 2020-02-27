using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public AudioSource typeAudio;
    public AudioClip typeClip;

    public float textSpeed = .02f;

    void Start()
    {
        sentences = new Queue<string>();
      
    }

   public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        Debug.Log("starting convo" + dialogue.name);

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence)
    {
        

        dialogueText.text= "";
        foreach(char letter in sentence.ToCharArray())
        {
            typeAudio.PlayOneShot(typeClip);
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
            yield return null;


        }
        typeAudio.Stop();

    }


    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
       
        Debug.Log("end of convo");
    }
}
