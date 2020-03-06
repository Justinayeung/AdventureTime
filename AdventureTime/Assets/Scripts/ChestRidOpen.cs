using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRidOpen : MonoBehaviour
{
    public GameObject ChestClosed;
    public GameObject ChestOpened;
    public GameObject chestInputCanvas;

    void Update()
    {
        if (StaticClass.amaranthusObtained) {
            ChestClosed.SetActive(false);
            ChestOpened.SetActive(true);
            chestInputCanvas.SetActive(false);
        } else {
            ChestClosed.SetActive(true);
            ChestOpened.SetActive(false);
            chestInputCanvas.SetActive(true);
        }
    }
}
