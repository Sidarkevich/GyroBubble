using System;
using UnityEngine;

public class SoapBubble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    private void OnCollisionEnter(Collision other)
    {
        
    }

    public void Move(Vector3 direction, float force)
    {
        //rb.AddForce(direction * force, ForceMode.VelocityChange);
        transform.Translate(direction.x * force, 0, 0);
    }
    
    private void Blow()
    {
        gameObject.SetActive(false);
    }
}
