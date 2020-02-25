using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    /// <summary>
    /// This spawns a dropped item near player
    /// </summary>
    public void SpawnDroppedItem() {
        Vector3 playerPos = new Vector3(player.position.x, player.position.y + 2f, player.position.z + 1.5f);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
