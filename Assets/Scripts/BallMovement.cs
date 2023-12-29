using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        
        if (rb != null) {
            rb.freezeRotation = true; 
        }
    }

    void Update() {
        if (rb != null) {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontalInput, 0, 0);
            rb.AddForce(movement * speed);
        }
    }
}