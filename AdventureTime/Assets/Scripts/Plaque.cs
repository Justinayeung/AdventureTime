using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plaque : MonoBehaviour
{
    public bool isRiddleThere = false;
    public GameObject Riddle;

    public Text riddleText;
    public Animator riddleAnim;

    private void Start()
    {
        Riddle.SetActive(false);

    }

    private void Update()
    {
        if (isRiddleThere)
        {
            return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRiddleThere = true;
            Riddle.SetActive(true);
            riddleAnim.SetBool("isShowing", true);

        }
    }

    public void ExitRiddle()
    {
        Riddle.SetActive(false);
        riddleAnim.SetBool("isShowing", false);

    }
}
