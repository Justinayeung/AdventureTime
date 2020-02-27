using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class StartPosition : SceneController
{
    public Transform player;
    [Tooltip("From MainMenu")]
    public Transform mainMenuPos; //From MainMenu
    [Tooltip("From MainPathway")]
    public Transform maintoStartPos; //From MainPathway

    //Checking which is the previous scene and setting location 
    public override void Start() {
        base.Start();
        StartCoroutine(CharacterPosition());
    }

    /// <summary>
    /// Setting player position to specific transforms based on scene names
    /// </summary>
    /// <returns></returns>
    IEnumerator CharacterPosition() {
        yield return new WaitForSeconds(0.3f);
        if (prevScene == "MainMenu") {
            player.position = mainMenuPos.position;
        } else if (prevScene == "MainPathway") {
            player.position = maintoStartPos.position;
        }
    }
}
