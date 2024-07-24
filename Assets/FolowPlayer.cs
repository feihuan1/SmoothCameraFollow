using UnityEngine;

public class FolowPlayer : MonoBehaviour
{

    public Transform Player;
    Vector3 offset = new Vector3(0f, 0f, -20f);

    void Update()
    {
        transform.position = Player.position + offset;
    }
}
