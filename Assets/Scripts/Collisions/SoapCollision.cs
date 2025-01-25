using System;
using UnityEngine;

public class SoapCollision : MonoBehaviour
{
    [SerializeField] private SoapBubble bubble;

    private void OnCollisionEnter(Collision other)
    {
        bubble.Blow();
    }
}
