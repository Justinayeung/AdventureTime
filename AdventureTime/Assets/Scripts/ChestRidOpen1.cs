using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRidOpen1 : MonoBehaviour
{
    public GameObject ChestClosed;
    public GameObject ChestOpened;
    public GameObject chestInputCanvas;

    void Update()
    {
        if (StaticClass.mushObtained) {
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
