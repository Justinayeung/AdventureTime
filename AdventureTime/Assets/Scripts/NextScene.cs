using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    [SerializeField] private string SceneName;
    private SceneController sceneController;
    public Image black;
    public Animator anim;

    void Start() {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(Ending()); //Starting fade coroutine
        }
    }

    /// <summary>
    /// Fading and change scene when fade is done
    /// </summary>
    /// <returns></returns>
    IEnumerator Ending() {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(SceneName);
    }
}
