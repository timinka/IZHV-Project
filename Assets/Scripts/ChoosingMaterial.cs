using UnityEngine;
using UnityEngine.UI;

public class MaterialPlacement : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public Material material3;
    public Button placeButton;      // Button to trigger material placement
    public GameObject placedObject; // The object to be placed

    private int currentIndex = 0;   // Index to track the current material
    private bool objectVisible = false;  // Flag to track object visibility

    void Start()
    {
        // Add a listener to the button click event
        placeButton.onClick.AddListener(PlaceMaterial);

        // Update instruction text
        UpdateInstructionText();
    }

    void PlaceMaterial()
    {
        // Assign the selected material to the placed object
        placedObject.GetComponent<Renderer>().material = materials[currentIndex];

        // Toggle object visibility
        objectVisible = true;

        // Cycle to the next material
        currentIndex = (currentIndex + 1) % materials.Length;

        // Update instruction text
        UpdateInstructionText();
    }

    void UpdateInstructionText()
    {
        // Display instructions based on the current material
        instructionText.text = "Select a material to place: " + materials[currentIndex].name;
    }

    void Update()
    {
        // Toggle object visibility based on player's choice
        placedObject.SetActive(objectVisible);
    }
}