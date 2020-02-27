using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class PathOtherPositions : SceneController
{
    public Transform player;
    [Tooltip ("From Main")]
    public Transform mainPath; //From MainPathway
    [Tooltip("From V1")]
    public Transform village1; //From V1
    [Tooltip("From V2")]
    public Transform village2; //From V2
    [Tooltip("From FlowerRid")]
    public Transform flowerRid; //From FlowerRiddle

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
        if (prevScene == "MainPathway") {
            player.position = mainPath.position;
        } else if (prevScene == "V1") {
            player.position = village1.position;
        } else if (prevScene == "V2") {
            player.position = village2.position;
        } else if (prevScene == "FlowerRid") {
            player.position = flowerRid.position;
        }
    }
}
