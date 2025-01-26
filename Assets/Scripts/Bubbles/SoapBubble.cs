using System;
using UnityEngine;

public class SoapBubble : MonoBehaviour
{
    public void Blow()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Translate(0, Time.deltaTime * 1.5f, 0);
    }
}
