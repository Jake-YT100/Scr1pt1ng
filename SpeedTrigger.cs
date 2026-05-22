using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    private void OnTriggerEnter(Collider other)
    {
        //Speed up
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    private void OnTriggerExit(Collider other)
    {
        //Speed down
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }


}
