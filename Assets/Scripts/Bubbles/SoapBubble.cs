using System;
using UnityEngine;

public class SoapBubble : MonoBehaviour
{
    private Rigidbody _otherBody;

    public void SetOther(Rigidbody rb)
    {
        _otherBody = rb;
    }
    
    public void Blow()
    {
        if (_otherBody)
            ApplyRandomForce(_otherBody);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0, Time.deltaTime * 1.5f, 0);
    }
    
    private void ApplyRandomForce(Rigidbody rb)
    {
        rb.angularVelocity = Vector3.zero;
        
        Vector3 randomDirection = new Vector3(
            UnityEngine.Random.Range(-1f, 1f),
            UnityEngine.Random.Range(0f, 0f),
            UnityEngine.Random.Range(0f, 0f)
        ).normalized;
        
        rb.AddForce(randomDirection * 10f, ForceMode.VelocityChange);
    }
}
