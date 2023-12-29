using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RetryController : MonoBehaviour, IPointerClickHandler
{
    public TMPro.TMP_Dropdown dropdownMenu1;
    public TMPro.TMP_Dropdown dropdownMenu2;
    public TMPro.TMP_Dropdown dropdownMenu3;
    public TMPro.TMP_Dropdown dropdownMenu4;
    public GameObject buttonPlay;
    public GameObject buttonRetry;
    public GameObject victoryText;

    public void OnPointerClick(PointerEventData eventData)
    {
        dropdownMenu1.gameObject.SetActive(true);
        dropdownMenu1.value = 0;
        dropdownMenu2.gameObject.SetActive(true);
        dropdownMenu2.value = 0;
        dropdownMenu3.gameObject.SetActive(true);
        dropdownMenu3.value = 0;
        dropdownMenu4.gameObject.SetActive(true);
        dropdownMenu4.value = 0;

        buttonPlay.SetActive(true);
        buttonRetry.SetActive(false);
        victoryText.SetActive(false);
        DestroyAllPrefabInstances("CubeGlass");
        DestroyAllPrefabInstances("CubeRubber");
        DestroyAllPrefabInstances("CubeWater");
    }

    void DestroyAllPrefabInstances(string prefabTag) {
        GameObject[] prefabInstances = GameObject.FindGameObjectsWithTag(prefabTag);

        foreach (var instance in prefabInstances) {
            GameObject.Destroy(instance);
        }
    }
}