using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;  
    public int numberOfCubes = 3;   
    public float gapBetweenCubes = 4.0f;  

    void Start() {
        SpawnCubes();
    }

    void SpawnCubes() {
        for (int i = 0; i < 4; i++) {
            Vector3 spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 0.0f, 6.0f);
            GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            newCube.transform.SetParent(transform);
            if (i == 0) {
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 1.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 4.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 5.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
            } else if (i == 1) {
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 1.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 3.0f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
            } else if (i == 2) {
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 4.0f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 5.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
            } else if (i == 3) {
                spawnPosition = new Vector3(i * gapBetweenCubes - 4.0f, 1.5f, 6.0f);
                newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
                newCube.transform.SetParent(transform);
            }
        }
    }
}
