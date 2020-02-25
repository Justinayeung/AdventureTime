using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPathPosition : SceneController
{
    public Transform player;
    public Transform startPos; //Previous scene is start
    public Transform GodPos; //Previous scene is god
    public Transform ChestRiddlePos; //Previous scene is the path leading to the chest riddle
    public Transform OtherRiddlePos; //Previous scene is the path leading to the other riddles

    //Checking which is the previous scene and setting location 
    public override void Start() {
        base.Start();
        StartCoroutine(CharacterPosition());
    }

    IEnumerator CharacterPosition() {
        yield return new WaitForSeconds(0.3f);
        if (prevScene == "LevelStart") {
            player.position = startPos.position;
        } else if (prevScene == "God") {
            player.position = GodPos.position;
        } else if (prevScene == "GodRiddle") {
            player.position = GodPos.position;
        } else if (prevScene == "ChestRiddle") {
            player.position = ChestRiddlePos.position;
        }
    }
}
