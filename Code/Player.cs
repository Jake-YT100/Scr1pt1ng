using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioClip damageSound;
    public AudioClip collectSound;
    //Player's health
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins;
    public void CollectCoins()
    {
        coins++;
        audioSource2.PlayOneShot(collectSound);
        print("Coins:" + coins);
    }
    //Player's damage
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            audioSource1.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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
