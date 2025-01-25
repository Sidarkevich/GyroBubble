using System;
using UnityEngine;

public class Vent : MonoBehaviour
{
    [SerializeField] private float forceValue;
    [SerializeField] private Vector3 forceVector;

    [SerializeField] private GameObject onState;
    [SerializeField] private GameObject offState;
    [SerializeField] private Collider windCollider;
    
    public void SetState(bool state)
    {
        onState.SetActive(state);
        offState.SetActive(!state);
        windCollider.enabled = state;
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Default")
        {
            other.attachedRigidbody.AddForce(forceVector * forceValue, ForceMode.VelocityChange);
        }
    }
}
