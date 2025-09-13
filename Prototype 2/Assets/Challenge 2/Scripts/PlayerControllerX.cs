using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnCooldown = 0.6f;
    private bool dogSpawnEnabled = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawnEnabled)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            dogSpawnEnabled = false;
            Invoke("EnableDogSpawn", dogSpawnCooldown);
        }
    }

    void EnableDogSpawn()
    {
        dogSpawnEnabled = true;
    }
}
