using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChestInput : MonoBehaviour
{
    public const string Letter_Tag = "Letter";
    private bool dragging = false;
    private Vector3 letterInitialPos;
    private Transform letterToDrag;
    private Image letterImage;

    List<RaycastResult> hitObjects = new List<RaycastResult>();

    void Update() {
        //If mouse is held
        if (Input.GetMouseButtonDown(0)) {
            letterToDrag = GetLetterTransform(); //Get letter transform
            if (letterToDrag != null) {
                dragging = true;
                letterToDrag.SetAsLastSibling(); //Move transform to the end of local transform list
                letterInitialPos = letterToDrag.position; //Setting inital position to when we first click the letter 
                letterImage = letterToDrag.GetComponent<Image>();
                letterImage.raycastTarget = false; //Can't see raycast iamge
            }
        }

        // If dragging is true
        if (dragging) {
            letterToDrag.position = Input.mousePosition; //Setting position of image to mouse position
        }

        //If mouse is released
        if (Input.GetMouseButtonUp(0)) {
            if (letterToDrag != null) {
                Transform letterToReplace = GetLetterTransform(); //Detect and replace letter underneath
                if (letterToReplace != null) { //If we are placing current letter on another draggable letter
                    letterToDrag.position = letterToReplace.position; //Swapping positions with letter underneath
                    letterToReplace.position = letterInitialPos; //Become the letter's new original position
                } else {
                    letterToDrag.position = letterInitialPos; //Reset letter to its inital position
                }

                letterImage.raycastTarget = true; //Allowing letter to be dragged again
                letterToDrag = null;
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
        if (clickedObject != null && clickedObject.tag == Letter_Tag) {
            return clickedObject.transform;
        }
        return null;
    }
}
