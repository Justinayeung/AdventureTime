using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingText : MonoBehaviour
{
    public bool loadScene;
    private Text loadingText;
    
    // Start is called before the first frame update
    void Start() {
        loadingText = GetComponent<Text>();
        loadScene = true; //Start every scene with it true
    }

    // Update is called once per frame
    void Update()
    {
        //If loadScene is false
        if (!loadScene) {
            loadingText.text = ""; //Setting text
        }

        //If loadScene is true
        if (loadScene) {
            loadingText.text = "LOADING. . ."; //Setting text
            //Change the transparency of the text
            loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, Mathf.PingPong(Time.time, 1));
        }
    }
}
