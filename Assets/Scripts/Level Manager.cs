using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public LevelManager instance;
    [Header("Currency")]
    public int currency = 0;
    public Text currencyUI;

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
        currencyUI.text = ":wastebasket:" + currency;
    }
}