using System;
using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField] private float forceValue;
    [SerializeField] private Vector3 forceVector;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Default")
        {
            other.attachedRigidbody.AddForce(forceVector * forceValue, ForceMode.VelocityChange);
        }
    }
}
