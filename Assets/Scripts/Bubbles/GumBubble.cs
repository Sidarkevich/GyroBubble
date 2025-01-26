using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GumBubble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        var soap = other.transform.parent.gameObject.GetComponent<SoapBubble>();
        
        if (soap != null)
            soap.SetOther(rb);
    }

    private void OnBecameInvisible()
    {
        SceneManager.LoadScene(0);
    }
}
