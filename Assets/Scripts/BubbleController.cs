using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class BubbleController : MonoBehaviour
{
    [SerializeField] private GameObject defaultState;
    [SerializeField] private GameObject gumState;
    [SerializeField] private Rigidbody defaultBody;
    [SerializeField] private Rigidbody gumBody;
    [Space]
    [SerializeField] private Vector3 defaultGravityVector;
    [SerializeField] private Vector3 antiGravityVector;
    [Space]
    [SerializeField] private List<Vent> leftVents;
    [SerializeField] private List<Vent> rightVents;
    
    private bool _isDefaultGravity = true;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            defaultBody.linearVelocity = new Vector3();
            gumBody.linearVelocity = new Vector3();
            
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

        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var vent in leftVents)
            {
                vent.SetState(true);
            }   
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            foreach (var vent in leftVents)
            {
                vent.SetState(false);
            }  
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (var vent in rightVents)
            {
                vent.SetState(true);
            }   
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            foreach (var vent in rightVents)
            {
                vent.SetState(false);
            }  
        }
    }
}
