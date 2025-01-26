using System;
using UnityEngine;

public class GumBubble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Container")
            rb.angularVelocity = Vector3.zero;
    }
}
