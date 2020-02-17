using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [Header ("References")]
    public Transform target;

    [Header("Variables")]
    public Vector3 offset;
    public float speed;
    public float endTime;

    private float time;
    Vector3 cameraPos;

    void Start() {
        cameraPos = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z); //Adding offset to position of target (player)
    }

    void Update() {
        
    }

    void LateUpdate() {
        CameraMovement();
    }

    /// <summary>
    /// Rotates camera around player for a certain time
    /// </summary>
    public void CameraMovement() {
        time += Time.deltaTime;
        if (time < endTime) { //If time less than the endTime
            cameraPos = Quaternion.AngleAxis(speed, Vector3.up) * cameraPos; //Rotate camera
            transform.position = target.position + cameraPos; //Setting camera position
            transform.LookAt(target.position); //Camera look at target (player)
        }
    }
}
