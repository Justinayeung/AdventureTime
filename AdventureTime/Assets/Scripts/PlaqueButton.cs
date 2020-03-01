using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaqueButton : MonoBehaviour
{
    public Animator riddleAnim;

    /// <summary>
    /// Button to close plaque
    /// </summary>
    public void CloseRid() {
        riddleAnim.SetBool("isShowing", false);
    }
}
