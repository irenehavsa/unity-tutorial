using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // When the projectile and an animal collide, destroy both of them
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
