using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        // Check if Rigidbody is not null
        if (rb != null)
        {
            rb.freezeRotation = true; // Freeze rotation to prevent unwanted rotations
        }
        else
        {
            Debug.LogError("Rigidbody component not found on the GameObject.");
        }
    }

    void Update()
    {
        // Check if Rigidbody is not null before using it
        if (rb != null)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontalInput, 0, 0);
            rb.AddForce(movement * speed);
        }
    }
    // public float speed = 5f;

    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");

    //     transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0));

    //     transform.position = new Vector3(transform.position.x, transform.position.y, 6.5f);
    //     transform.rotation = Quaternion.Euler(0, 0, 0);
    // }
}