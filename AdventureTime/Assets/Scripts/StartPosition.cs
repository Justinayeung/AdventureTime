using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class StartPosition : SceneController
{
    public Transform player;
    public Transform mainMenuPos; //Previous scene is the main menu
    public Transform maintoStartPos; //Previous scene is the main pathway

    //Checking which is the previous scene and setting location 
    public override void Start() {
        base.Start();
        StartCoroutine(CharacterPosition());
    }

    public void Update()
    {

    }

    IEnumerator CharacterPosition() {
        yield return new WaitForSeconds(0.3f);
        if (prevScene == "MainMenu")
        {
            player.position = mainMenuPos.position;
        }
        else if (prevScene == "MainPathway")
        {
            player.position = maintoStartPos.position;
        }
    }
}
