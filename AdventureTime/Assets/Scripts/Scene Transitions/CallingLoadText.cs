using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingLoadText : MonoBehaviour
{
    private Image black;

    // Start is called before the first frame update
    void Start() {
        black = GetComponent<Image>();
    }

    public void EnableImage() {
        black.enabled = true;
    }

    public void DisableImage() {
        black.enabled = false;
    }
}
