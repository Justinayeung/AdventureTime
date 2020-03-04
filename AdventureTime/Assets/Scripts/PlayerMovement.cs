using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[Header ("References")]
    private Camera cam;
    private NavMeshAgent agent;

    [Header ("Variables")]
    public float speed;
    public bool canMove;

    [Header("Animation")]
    public Animator anim;
    public Vector3 targetPosition;

    Rigidbody rb;
    Vector3 touchPos;

    // Start is called before the first frame update
    void Start() {
        canMove = true;
        rb = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        agent = GetComponent<NavMeshAgent>();
        targetPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update() {
        if (canMove) {
            PlayerMove();
            TouchController();
            MouseClickController();
            Walking();
        } else {
            anim.SetBool("IsWalking", false);
        }
    }

    /// <summary>
    /// Walking Animation Function
    /// </summary>
    public void Walking() {
        if (Vector3.Distance(transform.position, targetPosition) > 0.1f) 
        {
            anim.SetBool("IsWalking", true);
        }
        else {
            anim.SetBool("IsWalking", false);
        }
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
                if (Physics.Raycast(ray, out hit)) { //Shoots out ray
                    agent.SetDestination(hit.point);

                    //Checks if it hits a specific collider
                    if (hit.collider.tag == "") {
                        
                    }
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
            if (Physics.Raycast(ray, out hit)) { //Shoots out ray
                targetPosition = hit.point;
                agent.SetDestination(hit.point);

                //Checks if it hits a specific collider
                if (hit.collider.tag == "") {
                    
                }
            }
        }
    }
    /*
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vines"))
        {
            // play break animation
            anim.SetTrigger("VineBreak");
        }
    }
    */
}
