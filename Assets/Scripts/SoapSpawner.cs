using System;
using UnityEngine;

public class SoapSpawner : MonoBehaviour
{
    [SerializeField] private GameObject soapPrefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 5f);
    }

    void Spawn()
    {
        Instantiate(soapPrefab.transform);
    }
}
