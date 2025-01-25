using System;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    [SerializeField] private GameObject defaultState;
    [SerializeField] private GameObject gumState;
    [Space]
    [SerializeField] private Vector3 defaultGravityVector;
    [SerializeField] private Vector3 antiGravityVector;
    
    private bool _isDefaultGravity = true;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isDefaultGravity)
            {
                _isDefaultGravity = false;
                Physics.gravity = antiGravityVector;
                defaultState.transform.position = gumState.transform.position;
            }
            else
            {
                _isDefaultGravity = true;
                Physics.gravity = defaultGravityVector;
                gumState.transform.position = defaultState.transform.position;
            }
            
            defaultState.SetActive(!defaultState.activeInHierarchy);
            gumState.SetActive(!gumState.activeInHierarchy);
        }
    }
}
