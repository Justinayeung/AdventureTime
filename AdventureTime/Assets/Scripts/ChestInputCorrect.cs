using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChestInputCorrect : MonoBehaviour
{
    public Animator anim;
    public Animator ridAnim;
   

    /// <summary>
    /// Check if all the letters are in the correct positions (if so, open chest)
    /// </summary>
    public void CheckPlayerInput() {
        if (StaticClass.LetterA && StaticClass.LetterI && StaticClass.LetterR) {
            ridAnim.SetBool("isShowing", false);
            StartCoroutine(WaitChestAnim());
            StaticClass.ChestRidSolved = true;
        }
    }

    /// <summary>
    /// Wait a bit before opening chest
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitChestAnim() {
        yield return new WaitForSeconds(0.3f);
        anim.SetBool("Open", true);
    }
}
