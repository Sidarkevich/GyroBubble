using System;
using UnityEngine;

public class Forcer : MonoBehaviour
{
    [SerializeField] private float forcePower;
    
    private void OnCollisionEnter(Collision other)
    {
        var vector = other.transform.position - transform.position;
        
        other.rigidbody.AddForce(vector * forcePower, ForceMode.Impulse);
    }
}
