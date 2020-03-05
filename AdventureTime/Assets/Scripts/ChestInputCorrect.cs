using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChestInputCorrect : MonoBehaviour
{
    public ChestInput Playerinput;
    public Animator anim;
    public Animator ridAnim;
   

    /// <summary>
    /// Check if all the letters are in the correct positions (if so, open chest)
    /// </summary>
    public void CheckPlayerInput() {
        if (Playerinput.LetterA && Playerinput.LetterI && Playerinput.LetterR) {
            anim.SetBool("Open", true);
            ridAnim.SetBool("isShowing", false);
           

        }
        else {
            anim.SetBool("Open", false);
        }
    }
}
