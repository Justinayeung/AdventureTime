using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static string prevScene = "";
    public static string currentScene = "";

    /// <summary>
    /// Sets our current scene variable
    /// </summary>
    public virtual void Start() {
        //Meant to be extended/overwritten by a scene script
        currentScene = SceneManager.GetActiveScene().name;
    }

    /// <summary>
    /// Set prevScene variable before loading the next scene
    /// </summary>
    /// <param name="sceneName"></param>
    public void LoadScene(string sceneName) {
        prevScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }
}
