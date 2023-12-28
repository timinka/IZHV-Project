using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private float bounceForce = 20f; 

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.sharedMaterial != null) {
            if (collision.collider.CompareTag("Cube")) {
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                return; 
            }

            bool forcesApplied = false;

            for (int i = 0; i < collision.contacts.Length; i++) {
                ContactPoint contact = collision.contacts[i];

                if (!forcesApplied) {
                    if (contact.otherCollider.CompareTag("CubeWater")) {
                        bounceForce = 28;
                        forcesApplied = true;
                    } else if (contact.otherCollider.CompareTag("CubeRubber")) {
                        bounceForce = 22;
                        forcesApplied = true;
                    } else if (contact.otherCollider.CompareTag("CubeGlass")) {
                        bounceForce = 40;
                        forcesApplied = true;
                    }
                    
                    if (!collision.collider.CompareTag("Cube")) {
                        GetComponent<Rigidbody>().AddForce(-contact.normal * bounceForce, ForceMode.Impulse);
                    }
                    
                }
            }
        }
    }
}