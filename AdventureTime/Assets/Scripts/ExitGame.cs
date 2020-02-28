using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{


    public void OnClickExiting()
    {
        Application.Quit();
        Debug.Log("game is exiting");
    }
}
