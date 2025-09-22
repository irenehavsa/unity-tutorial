using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time in real seconds for one full in-game day cycle (360 degrees).")]
    public float dayLengthInSeconds = 120f; // default 2 minutes per day

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees per dayLengthInSeconds
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate around the X axis at the correct speed
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
