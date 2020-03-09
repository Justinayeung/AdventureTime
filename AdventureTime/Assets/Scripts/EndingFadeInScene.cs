using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingFadeInScene : MonoBehaviour
{
    [SerializeField] private string toScene;
    private SceneController sceneController;
    public Image white;
    public GameObject player;
    public GameObject fadein;

    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && StaticClass.haveClover && StaticClass.haveMushroom && StaticClass.haveAmaranthus)
        {
            StartCoroutine(Ending()); //Starting fade coroutine
            StaticClass.axUsed = true;
            StaticClass.cloverUsed = true;
            StaticClass.mushroomUsed = true;
        }
    }

    /// <summary>
    /// Fading and change scene when fade is done
    /// </summary>
    /// <returns></returns>
    IEnumerator Ending()
    {
        player.GetComponent<Animator>().SetTrigger("ThrowIngredient");
        fadein.GetComponent<Animator>().SetTrigger("FadeIn");
        yield return new WaitUntil(() => white.color.a == 1);
        sceneController.LoadScene(toScene);
    }
}
