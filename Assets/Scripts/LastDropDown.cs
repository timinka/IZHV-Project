using UnityEngine;
using UnityEngine.UI;

public class LastDropDownController : MonoBehaviour
{
    public TMPro.TMP_Dropdown myDrop;
    public GameObject waterPrefab;
    public GameObject rubberPrefab;
    public GameObject glassPrefab;
    private GameObject instantiatedPrefab;

    private void Start()
    {
        myDrop.onValueChanged.AddListener(delegate {
            PlacingBoxes();
        });
    }

    private void PlacingBoxes() {
        DestroyPrefab();

        if (myDrop.value == 1) {
            InstantiatePrefab(waterPrefab);
        } else if (myDrop.value == 2) {
            InstantiatePrefab(glassPrefab);
        } else if (myDrop.value == 3) {
            InstantiatePrefab(rubberPrefab);
        }
    }

    private void InstantiatePrefab(GameObject prefab) {
        Vector3 spawnPosition = myDrop.transform.position - new Vector3(-2, 3.37f, -2.25f);
        instantiatedPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

     private void DestroyPrefab() {
        if (instantiatedPrefab != null) {
            Destroy(instantiatedPrefab);
            instantiatedPrefab = null; 
        }
    }
}