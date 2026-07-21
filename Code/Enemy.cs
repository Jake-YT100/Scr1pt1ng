using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy's speed
    public float speed;
    //Enemy's target
    public Transform target;
    //Damage points
    public int playerDamage = 2;
    void Update()
    {
        //NPC's move
        transform.position =
      Vector3.MoveTowards(transform.position,
      target.position, speed * Time.deltaTime);
        //NPC's rotate
        transform.LookAt(target.position);
    }
    //Enemy attacked player
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player)
        {
            player.TakeDamage(playerDamage);
        }
    }
}
