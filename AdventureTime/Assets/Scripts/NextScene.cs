using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public string SceneName;
    public Image black;
    public Animator anim;

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
