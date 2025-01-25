using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SoapBubble movable;
    [SerializeField] private float forceValue;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movable.Move(Vector3.left, forceValue);
        }

        if (Input.GetKey(KeyCode.D))
        {
            movable.Move(Vector3.right, forceValue);
        }
    }
}
