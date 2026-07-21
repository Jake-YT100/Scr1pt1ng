using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public int platSpeed;
    public Vector3 platWay;
    public bool platActivity;
    public void Update()
    {
        if (platActivity)
        {
            transform.position += platWay * platSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ERROR: NO ERROR");
        if (other.gameObject.CompareTag("Upper"))
        {
            platWay = Vector3.down;
        }
        if (other.gameObject.CompareTag("Lower"))
        {
            platWay = Vector3.up;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            platActivity = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            platActivity = false;
        }
    }
}
