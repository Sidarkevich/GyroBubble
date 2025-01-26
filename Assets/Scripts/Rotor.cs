using UnityEngine;

public class Rotor : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * 0.35f);
    }
}
