using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script sets player position based on previous scene, derives from SceneController class
/// </summary>
public class V2Position : SceneController
{
    public Transform player;
    [Tooltip("From PathOther")]
    public Transform PathPos; //From PathOther
    [Tooltip("From EnemyBase")]
    public Transform EnemyPos; //From EnemyBase

    //Checking which is the previous scene and setting location 
    public override void Start()
    {
        base.Start();
        StartCoroutine(CharacterPosition());
    }

    /// <summary>
    /// Setting player position to specific transforms based on scene names
    /// </summary>
    /// <returns></returns>
    IEnumerator CharacterPosition()
    {
        yield return new WaitForSeconds(0.3f);
        if (prevScene == "PathOther")
        {
            player.position = PathPos.position;
        }
        else if (prevScene == "EnemyBase")
        {
            player.position = EnemyPos.position;
        }
    }
}
