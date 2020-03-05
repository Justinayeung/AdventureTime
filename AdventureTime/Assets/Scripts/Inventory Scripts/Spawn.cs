using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour // This is more like destorying UI script
{
    /*
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
    */

    void Update()
    {
        if (StaticClass.axUsed == true) {  // destory the ax when it is used
            Destroy(this.gameObject, 0.5f);
        }
        if (StaticClass.cloverUsed == true)  // destory the clover when it is used
        {
            Destroy(this.gameObject, 0.5f);
        }
        if (StaticClass.posionUsed == true)  // destory the posion when it is used
        {
            Destroy(this.gameObject, 0.5f);
        }
    }
}
