using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    void Update()
    {
        //Update player's health
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
        //Update count of coins
        coinsCounterText.text = player.coins.ToString();
    }
}
