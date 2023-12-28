using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private float bounceForce = 20f; 
    private float forwardForce = 400f;

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.sharedMaterial != null) {
            bool forcesApplied = false;

            for (int i = 0; i < collision.contacts.Length; i++) {
                ContactPoint contact = collision.contacts[i];

                if (!forcesApplied) {
                    if (contact.otherCollider.CompareTag("CubeWater")) {
                        bounceForce = 28;
                        forwardForce = 215;
                        forcesApplied = true;
                    } else if (contact.otherCollider.CompareTag("CubeRubber")) {
                        bounceForce = 22;
                        forwardForce = 200;
                        forcesApplied = true;
                    } 
                    // else if (next obj) {
                    //     bounceForce = 40;
                    //     forwardForce = 200;
                    //     forcesApplied = true;
                    // }    
                
                    GetComponent<Rigidbody>().AddForce(-contact.normal * bounceForce, ForceMode.Impulse);
                    GetComponent<Rigidbody>().AddForce(transform.right * forwardForce, ForceMode.Force);
                }
            }
        }
    }
}