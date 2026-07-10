using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Player's health
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins;
    public void CollectCoins()
    {
        coins++;
        AudioSource.PlayOneShot(collectSound);
        print("Coins:" + coins);
    }
    //Player's damage
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("HP: " + health);
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      attackPoint.
      position, attackPoint.
      rotation);
        }
    }
}
