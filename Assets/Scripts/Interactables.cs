using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public LevelManager lm;
    public int points = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            lm.instance.IncreaseCurrency(points);
        }
    }
    void Update()
    {

    }
}