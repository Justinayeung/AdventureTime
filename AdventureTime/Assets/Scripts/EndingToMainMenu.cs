using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingToMainMenu : MonoBehaviour
{
    public string sceneName;
    public Image black;
    public Animator anim;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(Ending()); //Starting fade coroutine
        }
    }

    IEnumerator Ending()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(sceneName);
    }
}
