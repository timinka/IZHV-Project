using UnityEngine;

public class PlusSpawner : MonoBehaviour
{
    public GameObject PlusButtonPrefab;  
    public int numberOfPlus = 3; 
    public float gapBetweenCubes = 4.0f;  

    void Start()
    {
        SpawnPlus();
    }

    void SpawnPlus()
    {
        for (int i = 0; i < 3; i++) {
            Vector3 spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 0.0f, 5.0f);
            GameObject Plus = Instantiate(PlusButtonPrefab, spawnPosition, Quaternion.identity);
            Plus.transform.SetParent(transform);
        }
    }
}
