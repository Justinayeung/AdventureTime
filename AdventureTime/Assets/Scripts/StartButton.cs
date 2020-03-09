using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string SceneName;
    public AudioSource buttonAudio;

    public void LoadScene()
    {
        buttonAudio.Play();
        SceneManager.LoadScene(SceneName);
        StaticClass.inventoryDestroy = false;
    }
}
