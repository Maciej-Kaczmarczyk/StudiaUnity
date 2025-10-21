using UnityEngine;
using System.Collections.Generic;

public class CubeSpawner: MonoBehaviour
{
    public GameObject cubePrefab;
    public int numberOfCubes = 10;
    public float areaSize = 10f;

    private List<Vector3> usedPositions = new List<Vector3>();

    void Start()
    {
        SpawnCubes();
    }

    void SpawnCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 randomPosition = GetUniqueRandomPosition();
            Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }

    Vector3 GetUniqueRandomPosition()
    {
        Vector3 position;
        int attempts = 0;

        do
        {
            float x = Random.Range(-areaSize / 2f, areaSize / 2f);
            float z = Random.Range(-areaSize / 2f, areaSize / 2f);
            position = new Vector3(Mathf.Round(x), 0.5f, Mathf.Round(z));
            attempts++;
        }
        while (usedPositions.Contains(position) && attempts < 100);

        usedPositions.Add(position);
        return position;
    }
}
