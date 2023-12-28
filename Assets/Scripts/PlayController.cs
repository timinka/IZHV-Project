using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlatController : MonoBehaviour, IPointerClickHandler
{
    public TMPro.TMP_Dropdown dropdownMenu1;
    public TMPro.TMP_Dropdown dropdownMenu2;
    public TMPro.TMP_Dropdown dropdownMenu3;
    public TMPro.TMP_Dropdown dropdownMenu4;
    public GameObject ball;
    public GameObject buttonPlay;
    public GameObject buttonEdit;

    void Start()
    {
        ball.SetActive(false);
        buttonEdit.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        dropdownMenu1.gameObject.SetActive(false);
        dropdownMenu2.gameObject.SetActive(false);
        dropdownMenu3.gameObject.SetActive(false);
        dropdownMenu4.gameObject.SetActive(false);
        ball.SetActive(true);
        ball.transform.position = new Vector3(-8.03f, 2.55f, 6.5f);
        buttonPlay.SetActive(false);
        buttonEdit.SetActive(true);
    }
}