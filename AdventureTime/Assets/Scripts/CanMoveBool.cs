using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMoveBool : MonoBehaviour
{
    private PlayerMovement player;

    void Start() {
        player = FindObjectOfType<PlayerMovement>();
    }

    public void CanMoveTrue() {
        player.canMove = true;
    }

    public void CanMoveFalse() {
        player.canMove = false;
    }
}
