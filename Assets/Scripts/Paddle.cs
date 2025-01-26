using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private UnityEngine.KeyCode inputCode;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    
    private float _rotationValue;
    private Vector3 _startRotation;
    
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

    private void Start()
    {
        _startRotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        if (Input.GetKey(inputCode))
        {
            RotationValue += rotationSpeed;
            
            return;
        }

        RotationValue -= rotationSpeed;
    }
    
    void FixedUpdate()
    {
        //вращать надо по х
        Quaternion deltaRotation = Quaternion.Euler(minZ + _rotationValue * (maxZ - minZ), _startRotation.y,_startRotation.z);
        
        rb.MoveRotation(deltaRotation);
    }
}
