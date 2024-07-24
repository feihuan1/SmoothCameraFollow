using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpHeight = 500f; 

    bool onFloor = true;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space) && onFloor)
        {
            rb.AddForce(0, jumpHeight * Time.deltaTime, 0, ForceMode.Impulse); 
            onFloor = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Onfloor");
            onFloor = true;
        }
    }
}
