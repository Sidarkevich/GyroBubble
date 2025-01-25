using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private Gyroscope gyro;
    private Quaternion rot;

    void Start()
    {
        // Enable Gyroscope if available
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            
            // Set the initial rotation of the device
            rot = new Quaternion(0, 0, 1, 0); // Set initial orientation for proper rotation
        }
        else
        {
            Debug.LogError("Gyroscope not supported on this device.");
        }
    }

    void Update()
    {
        // Apply rotation based on gyroscope
        if (gyro != null)
        {
            // This uses the gyroscope's attitude (rotation of the device in world space)
            transform.rotation = gyro.attitude * rot;
        }
    }
}