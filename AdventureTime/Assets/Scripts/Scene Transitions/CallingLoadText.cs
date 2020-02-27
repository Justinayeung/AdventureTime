using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingLoadText : MonoBehaviour
{
    private LoadingText loadingText;

    // Start is called before the first frame update
    void Start() {
        //Finding gameobject with tag LoadingText
        loadingText = GameObject.FindGameObjectWithTag("LoadingText").GetComponent<LoadingText>();
    }

    //Setting loading text bool to false
    public void CallingText() {
        loadingText.loadScene = false;
    }
}
