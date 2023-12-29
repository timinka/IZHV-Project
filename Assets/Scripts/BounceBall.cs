using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private float bounceForce = 20f; 
    public GameObject buttonRetry;
    public GameObject victoryText;
    public GameObject buttonEdit;
    public GameObject ball;

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.sharedMaterial != null) {
            if (collision.collider.CompareTag("Cube")) {
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                return; 
            }

            if (collision.collider.CompareTag("Finish")) {
                buttonRetry.SetActive(true);
                victoryText.SetActive(true);
                buttonEdit.SetActive(false);
                ball.SetActive(false);
                return; 
            }

            if (collision.collider.CompareTag("Portal")) {
                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
                ballRigidbody.velocity = Vector3.zero;
                ballRigidbody.angularVelocity = Vector3.zero;
                ball.transform.position = new Vector3(-8.03f, 2.55f, 6.5f);
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
                        bounceForce = 45;
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