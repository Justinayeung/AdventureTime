using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingFadeInScene : MonoBehaviour
{
    [SerializeField] private string toScene;
    private SceneController sceneController;
    public Image white;

    [Header("Animation")]
    public GameObject player;
    public GameObject fadein;
    public GameObject items;
    public GameObject camera;

    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
        //items.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && StaticClass.haveClover && StaticClass.haveMushroom && StaticClass.haveAmaranthus)
        {
            StartCoroutine(Ending()); //Starting fade coroutine
            items.GetComponent<Animator>().SetTrigger("ItemThrow");
            camera.GetComponent<Animator>().SetTrigger("ZoomIn");
            StaticClass.amaranthusUsed = true;
            StaticClass.cloverUsed = true;
            StaticClass.mushroomUsed = true;
        }
    }

    /// <summary>
    /// Fading + Throwing Animation and change scene when fade is done
    /// </summary>
    /// <returns></returns>
    IEnumerator Ending()
    {
        player.GetComponent<Animator>().SetTrigger("ThrowIngredient");
        //items.GetComponent<Animator>().SetTrigger("ItemThrow");
        fadein.GetComponent<Animator>().SetTrigger("FadeIn");
        StaticClass.inventoryDestroy = true;
        yield return new WaitUntil(() => white.color.a == 1);
        sceneController.LoadScene(toScene);
    }
}
