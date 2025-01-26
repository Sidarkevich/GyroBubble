using System;
using UnityEngine;

public class GumBubble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        var soap = other.transform.parent.gameObject.GetComponent<SoapBubble>();
        
        if (soap != null)
            soap.SetOther(rb);
    }
}
