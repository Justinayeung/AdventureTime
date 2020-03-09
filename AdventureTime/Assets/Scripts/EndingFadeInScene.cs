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

    [Header("Items")]
    public GameObject clover;
    public GameObject mushroom;
    public GameObject amaranthus;
    public Transform playerTransform;

    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
        clover.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && StaticClass.haveClover && StaticClass.haveMushroom && StaticClass.haveAmaranthus)
        {
            StartCoroutine(Ending()); //Starting fade coroutine
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
        Vector3 playerPos = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);

        player.GetComponent<Animator>().SetTrigger("ThrowIngredient");
        fadein.GetComponent<Animator>().SetTrigger("FadeIn");
        yield return new WaitUntil(() => white.color.a == 1);
        sceneController.LoadScene(toScene);
    }
}
