using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 6, -9);

    // Update is called once per frame
    void LateUpdate()
    {
        // Update the camera in LateUpdate so it runs after the player (Vehicle) has moved
        // Apply an offset to the player's position to ensure the player stays visible
        transform.position = player.transform.position + offset;
    }
}
