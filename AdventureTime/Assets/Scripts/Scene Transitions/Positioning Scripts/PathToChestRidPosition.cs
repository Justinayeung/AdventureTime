using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class PathToChestRidPosition : SceneController
{
    public Transform player;
    [Tooltip("From Main")]
    public Transform mainPath; //From MainPathway
    [Tooltip("From Flower")]
    public Transform flower; //From FlowerField
    [Tooltip("From Chest")]
    public Transform chest; //From ChestRiddle

    //Checking which is the previous scene and setting location 
    public override void Start(){
        base.Start();
        StartCoroutine(CharacterPosition());
    }

    /// <summary>
    /// Setting player position to specific transforms based on scene names
    /// </summary>
    /// <returns></returns>
    IEnumerator CharacterPosition(){
        yield return new WaitForSeconds(0.3f);
        if (prevScene == "MainPathway") {
            player.position = mainPath.position;
        } else if (prevScene == "FlowerField") {
            player.position = flower.position;
        } else if (prevScene == "ChestRiddle") {
            player.position = chest.position;
        }
    }
}
