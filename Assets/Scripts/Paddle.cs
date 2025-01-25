using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float yAngle;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    
    [SerializeField] private float _rotationValue;

    private const float minValue = 0f;
    private const float maxValue = 1f;
    
    private float RotationValue
    {
        get => _rotationValue;
        set
        {
            if (value > maxValue)
            {
                _rotationValue = maxValue;
                return;
            }

            if (value < minValue)
            {
                _rotationValue = minValue;
                return;
            }

            _rotationValue = value;
        }
    }
    
    private void Update()
    {
        //transform.rotation = Quaternion.Euler(0, yAngle ,minZ + _rotationValue * (maxZ - minZ));
        
        if (Input.GetKey(KeyCode.S))
        {
            RotationValue += rotationSpeed;
            
            return;
        }

        RotationValue -= rotationSpeed;
    }
    
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(0f, yAngle,minZ + _rotationValue * (maxZ - minZ));
        
        rb.MoveRotation(deltaRotation);
    }
}
