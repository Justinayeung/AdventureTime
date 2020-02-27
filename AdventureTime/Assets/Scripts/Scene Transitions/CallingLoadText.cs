using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingLoadText : MonoBehaviour
{
    private LoadingText loadingText;
    private Image black;

    // Start is called before the first frame update
    void Start() {
        //Finding gameobject with tag LoadingText
        black = GetComponent<Image>();
        loadingText = GameObject.FindGameObjectWithTag("LoadingText").GetComponent<LoadingText>();
    }

    //Setting loading text bool to false
    public void CallingText() {
        loadingText.loadScene = false;
    }

    public void EnableImage() {
        black.enabled = true;
    }

    public void DisableImage() {
        black.enabled = false;
    }
}
