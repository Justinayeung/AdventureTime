using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class MainPathPosition : SceneController
{
    public Transform player;
    [Tooltip("From Start")]
    public Transform startPos; //From LevelStart
    [Tooltip("From God")]
    public Transform GodPos; //From God
    [Tooltip("From ChestPath")]
    public Transform ChestRiddlePos; //From PathToChestRid
    [Tooltip("From PathOther")]
    public Transform OtherRiddlePos; //From PathOther

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
        if (prevScene == "LevelStart") {
            player.position = startPos.position;
        } else if (prevScene == "God") {
            player.position = GodPos.position;
        } else if (prevScene == "GodRiddleTest") {
            player.position = GodPos.position;
        } else if (prevScene == "ChestRiddle") {
            player.position = ChestRiddlePos.position;
        } else if (prevScene == "PathOther") {
            player.position = OtherRiddlePos.position;
        }
    }
}
