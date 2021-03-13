using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    private int scoreNumber;
    void Start()
    {
        scoreNumber = 0;
        MyscoreText.text = "Collected trash: " + scoreNumber;
    }
    private void OnTriggerEnter2D(Collider apple, Collider banana, Collider can, Collider cola)
    {
        if (apple.tag == "Food" || can.tag == "Metal" || banana.tag == "Food" || cola.tag == "Metal") ;
        {
            scoreNumber += 1;
        }
    }
}