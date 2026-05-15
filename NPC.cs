using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //health of NPC
    public int health = 5;
    //level of NPC
    public int level = 1;
    //Speed of NPC
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //health pluse level
        health += level;
        print("health:" + health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
