using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(0f, 2f);
         Debug.Log("Spawn Height: " + randomY);

    Vector3 spawnPosition = new Vector3(
        transform.position.x,
        randomY,
        transform.position.z
    );

    Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
