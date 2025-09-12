using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
        //transform.Rotate(0, 0, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the collectible
            Destroy(gameObject);

            //Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }

    /*void onTriggerEnter(Collider other)
    {
        Debug.Log("This is a message from the Start function!");
        //Destroy the collectible
        Destroy(gameObject);

        Debug.Log("This is a message after debug");

        //Instantiate the particle effect
        //Instantiate(onCollectEffect, transform.position, transform.rotation);
    }*/
}
