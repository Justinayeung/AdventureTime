using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathToChestRidPosition : SceneController
{
    public Transform player;
    public Transform mainPath; //From MainPathway
    public Transform flower; //From FlowerField
    public Transform chest; //From ChestRiddle

    //Checking which is the previous scene and setting location 
    public override void Start(){
        base.Start();
        StartCoroutine(CharacterPosition());
    }

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
