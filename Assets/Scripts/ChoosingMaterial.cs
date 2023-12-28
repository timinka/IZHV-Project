using UnityEngine;

public class PlusButtonController : MonoBehaviour
{
    public GameObject waterPrefab;
    public GameObject rubberPrefab;
    public GameObject glassPrefab;

    public void OnButtonClick()
    {
        ShowOptions();
    }

    void ShowOptions()
    {
        // Implement the UI to show the options (e.g., a dropdown menu)
        // For simplicity, let's assume you have a UI script that handles this part

        // For demonstration purposes, I'll use Debug.Log to represent the user's selection
        Debug.Log("Options: Water, Rubber, Glass, None");

        // Assume you have a method to handle the user's selection
        HandleUserSelection();
    }

    void HandleUserSelection()
    {
        // Implement the logic to handle the user's selection
        // For simplicity, I'll use Debug.Log to represent the placement of the selected prefab

        // Assume you have a method to instantiate and place the selected prefab
        // You would replace the InstantiatePrefab method with your actual implementation
        InstantiatePrefab(waterPrefab); // Replace with the selected prefab
    }

    void InstantiatePrefab(GameObject prefab)
    {
        // Instantiate the selected prefab under the plus button
        Vector3 spawnPosition = transform.position - new Vector3(0, 1, 0);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}