using System;
using UnityEngine;

public class SoapBubble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    public void Move(Vector3 direction, float force)
    {
        transform.Translate(direction.x * force, 0, 0);
    }
    
    public void Blow()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Translate(0, Time.deltaTime * 0.5f, 0);
    }
}
