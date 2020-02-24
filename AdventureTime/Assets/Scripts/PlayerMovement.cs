using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header ("References")]
    public Camera cam;
    public NavMeshAgent agent;

    [Header ("Variables")]
    public float speed;

    [Header("Animation")]
    public Animator anim;
    Vector3 lastPosition;

    Rigidbody rb;
    Vector3 touchPos;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        PlayerMove();
        TouchController();
        MouseClickController();
        Walking();
    }

    public void Walking() {
        if (Vector3.Distance(transform.position, lastPosition) > 0.02f)
        {
            anim.SetBool("IsWalking", true);
        }
        else {
            anim.SetBool("IsWalking", false);
        }

        lastPosition = transform.position;
    }

    /// <summary>
    /// Move character using unity input (WASD or Arrows)
    /// </summary>
    public void PlayerMove() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, moveVertical * speed);
        rb.velocity = movement;

    }

    /// <summary>
    /// Touch to move player
    /// </summary>
    public void TouchController() {
        for (int i = 0; i < Input.touchCount; i++) {
            Touch touch = Input.GetTouch(i);

            //If screen if tapped
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                touchPos = touch.position; //Setting touchPos to where screen was tapped
                Ray ray = cam.ScreenPointToRay(touchPos); //Take touch position and convert it to a ray
                RaycastHit hit; //Stores info of what the ray hits

                //Move our NavMeshAgent
                if (Physics.Raycast(ray, out hit))
                { //Shoot out ray and checks if it hits something
                    agent.SetDestination(hit.point);
                }
            }
        }
    }

    /// <summary>
    /// Mouse click to move player
    /// </summary>
    public void MouseClickController() {
        if (Input.GetMouseButtonDown(0))  {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition); //Take mouse position and convert it to a ray
            RaycastHit hit; //Stores info of what the ray hits

            //Move our NavMeshAgent
            if (Physics.Raycast(ray, out hit))
            { //Shoot out ray and checks if it hits something
                agent.SetDestination(hit.point);
            }
        }
    }
}
