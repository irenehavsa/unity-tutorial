using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get user input
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rotate the camera
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        
    }
}
