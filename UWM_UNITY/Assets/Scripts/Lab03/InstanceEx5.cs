using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceEx5 : MonoBehaviour
{
    public GameObject prefabCube;

    void Start()
    {
        int numberOfPrefabs = 10;
        List<Vector3> occupiedPositions = new List<Vector3>();

        for(int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 randomPosition;
            do
            {
                int randx = Random.Range(-4, 5);
                int randz = Random.Range(-4, 5);
                randomPosition = new Vector3(randx, 1, randz);
                Debug.Log(randomPosition);
            } while (occupiedPositions.Contains(randomPosition));
            occupiedPositions.Add(randomPosition);

            Instantiate(prefabCube, randomPosition, Quaternion.identity);
        }
    }
}
