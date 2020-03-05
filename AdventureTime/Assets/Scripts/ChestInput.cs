using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChestInput : MonoBehaviour
{
    public const string Letter_Tag = "Letter";
    public Transform LetterSlot1;
    public Transform LetterSlot2;
    public Transform LetterSlot3;
    public Transform A;
    public Transform I;
    public Transform R;
    public bool LetterA, LetterI, LetterR;


    private bool dragging = false;
    private Vector3 letterInitialPos;
    private Transform letterToDrag;
    private Image letterImage;

    List<RaycastResult> hitObjects = new List<RaycastResult>();

    void Update() {
        checkPositions();

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

    /// <summary>
    /// Checking the distance of the letters to gameobject, setting bool to see if it is correct
    /// </summary>
    public void checkPositions() {
        float distance1 = Vector3.Distance(LetterSlot1.position, A.position);
        float distance2 = Vector3.Distance(LetterSlot2.position, I.position);
        float distance3 = Vector3.Distance(LetterSlot3.position, R.position);

        if (distance1 <= 10) { //Checking distance for letter A and slot 1
            LetterA = true;
        } else {
            LetterA = false;
        }

        if (distance2 <= 10) { //Checking distance for letter I and slot 2
            LetterI = true;
        } else {
            LetterI = false;
        }

        if (distance3 <= 10) { //Checking distance for letter R and slot 3
            LetterR = true;
        } else {
            LetterR = false;
        }
    }
}
