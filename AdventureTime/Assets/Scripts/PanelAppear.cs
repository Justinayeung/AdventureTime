using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelAppear : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
   
      StartCoroutine(ExitPanel());
    }

    IEnumerator ExitPanel()
    {

       
        yield return new WaitForSeconds(1f);
        panel.SetActive(true);
    }
    
}
