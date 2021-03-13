using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void spawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 3f, player.position.y - 1.3f);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
