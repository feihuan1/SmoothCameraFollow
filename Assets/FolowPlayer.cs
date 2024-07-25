using UnityEngine;

public class FolowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; 

    // the bigger , the faster the camera will lock on player(between 0-1)
    public float smoothSpeed = 0.125f;

// Update runs at same time, player and camera will completing each other
    // void Update()
    // {
    //     transform.position = Player.position + offset;
    // }
    void FixedUpdate()
    {
        
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position ,desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(player);
    }
}
