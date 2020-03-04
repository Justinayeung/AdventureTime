using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    public GameObject animationLeftMouseButton;
    private RaycastHit hit;
    private Ray ray;

    Vector3 touchPos;

    void Start()
    {
        QualitySettings.vSyncCount = 0; // disable vSync
    }

    // Update is called once per frame
    void Update()
    {
        MouseClickController();
        TouchController();
    }

    public void TouchController()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            //If screen if tapped
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                touchPos = touch.position; //Setting touchPos to where screen was tapped
                ray = Camera.main.ScreenPointToRay(touchPos); ;
                if (hit.collider.tag == "Platform")
                {
                    Instantiate(animationLeftMouseButton, new Vector3(hit.point.x, hit.point.y, hit.point.z), transform.rotation);
                }
            }
        }
    }

    public void MouseClickController()
    {
        if (Input.GetButtonDown("Fire1")) // on LMB 
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); //cast ray relative to mose position
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Platform")
                {
                    Instantiate(animationLeftMouseButton, new Vector3(hit.point.x, hit.point.y, hit.point.z), transform.rotation);
                }
            }
        }
    }
}
