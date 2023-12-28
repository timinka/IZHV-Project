using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EditController : MonoBehaviour, IPointerClickHandler
{
    public TMPro.TMP_Dropdown dropdownMenu1;
    public TMPro.TMP_Dropdown dropdownMenu2;
    public TMPro.TMP_Dropdown dropdownMenu3;
    public TMPro.TMP_Dropdown dropdownMenu4;
    public GameObject ball;
    public GameObject buttonEdit;
    public GameObject buttonDone;

    void Start()
    {
        ball.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        dropdownMenu1.gameObject.SetActive(true);
        dropdownMenu2.gameObject.SetActive(true);
        dropdownMenu3.gameObject.SetActive(true);
        dropdownMenu4.gameObject.SetActive(true);
        ball.SetActive(false);
        buttonEdit.SetActive(false);
        buttonDone.SetActive(true);
    }
}