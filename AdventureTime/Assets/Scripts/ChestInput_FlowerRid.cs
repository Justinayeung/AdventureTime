using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChestInput_FlowerRid : MonoBehaviour
{
    public const string Image_Tag = "Images";
    public Transform Slot1;
    public Transform Mushroom;


    private bool dragging = false;
    private Vector3 imageInitialPos;
    private Transform imageToDrag;
    private Image letterImage;

    List<RaycastResult> hitObjects = new List<RaycastResult>();

    void Update() {
        CheckPositions();

        //If mouse is held
        if (Input.GetMouseButtonDown(0)) {
            imageToDrag = GetLetterTransform(); //Get letter transform
            if (imageToDrag != null) {
                dragging = true;
                imageToDrag.SetAsLastSibling(); //Move transform to the end of local transform list
                imageInitialPos = imageToDrag.position; //Setting inital position to when we first click the image 
                letterImage = imageToDrag.GetComponent<Image>();
                letterImage.raycastTarget = false; //Can't see raycast iamge
            }
        }

        // If dragging is true
        if (dragging) {
            imageToDrag.position = Input.mousePosition; //Setting position of image to mouse position
        }

        //If mouse is released
        if (Input.GetMouseButtonUp(0)) {
            if (imageToDrag != null) {
                Transform letterToReplace = GetLetterTransform(); //Detect and replace letter underneath
                if (letterToReplace != null) { //If we are placing current letter on another draggable letter
                    imageToDrag.position = letterToReplace.position; //Swapping positions with letter underneath
                    letterToReplace.position = imageInitialPos; //Become the letter's new original position
                } else {
                    imageToDrag.position = imageInitialPos; //Reset letter to its inital position
                }

                letterImage.raycastTarget = true; //Allowing letter to be dragged again
                imageToDrag = null;
            }
            dragging = false;
        }
    }

    /// <summary>
    /// Find object under mouse
    /// </summary>
    /// <returns></returns>
    private GameObject GetObjectUnderMouse() {
        var pointer = new PointerEventData(EventSystem.current); //Store data from unity event system
        pointer.position = Input.mousePosition;
        EventSystem.current.RaycastAll(pointer, hitObjects); //Raycast from point position, check and store what the raycast hits into the list
        if (hitObjects.Count <= 0) return null; //return null if list is empty

        return hitObjects[0].gameObject; //return first gameobject
    }

    /// <summary>
    /// Get transform of object that matches the tag Letter
    /// </summary>
    private Transform GetLetterTransform() {
        GameObject clickedObject = GetObjectUnderMouse(); //Gameobject that returns the first gameobject hit by raycast
        if (clickedObject != null && clickedObject.tag == Image_Tag) {
            return clickedObject.transform;
        }
        return null;
    }

    /// <summary>
    /// Checking the distance of the letters to gameobject, setting bool to see if it is correct
    /// </summary>
    public void CheckPositions() {
        float distance1 = Vector3.Distance(Slot1.position, Mushroom.position);

        if (distance1 <= 10) { //Checking distance for letter A and slot 1
            StaticClass.mushImage = true;
        } else {
            StaticClass.mushImage = false;
        }
    }
}
