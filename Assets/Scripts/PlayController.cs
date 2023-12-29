using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayController : MonoBehaviour, IPointerClickHandler
{
    public TMPro.TMP_Dropdown dropdownMenu1;
    public TMPro.TMP_Dropdown dropdownMenu2;
    public TMPro.TMP_Dropdown dropdownMenu3;
    public TMPro.TMP_Dropdown dropdownMenu4;
    public GameObject ball;
    public GameObject buttonPlay;
    public GameObject buttonRetry;
    public GameObject victoryText;
    public GameObject buttonEdit;

    void Start()
    {
        ball.SetActive(false);
        buttonEdit.SetActive(false);
        victoryText.SetActive(false);
        buttonRetry.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        dropdownMenu1.gameObject.SetActive(false);
        dropdownMenu2.gameObject.SetActive(false);
        dropdownMenu3.gameObject.SetActive(false);
        dropdownMenu4.gameObject.SetActive(false);
        ball.SetActive(true);
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        // set ball movement to zero
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;
        ball.transform.position = new Vector3(-8.03f, 2.55f, 6.5f);
        buttonPlay.SetActive(false);
        buttonEdit.SetActive(true);
    }
}