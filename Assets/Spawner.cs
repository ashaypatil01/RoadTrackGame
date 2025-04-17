using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject enemyPrefab;
    public float spawnInterval = 2f; // Adjust as needed
    public float moveSpeed = 5f; // Speed of falling objects

    private float[] spawnPositions = { -8.52f, 0, 8.52f }; // Left, Middle, Right

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
    }

    void SpawnObject()
    {
        int randomIndex = Random.Range(0, spawnPositions.Length);
        float xPos = spawnPositions[randomIndex];

        bool isCoin = Random.value > 0.5f; // 50% chance of spawning a coin
        GameObject obj = Instantiate(isCoin ? coinPrefab : enemyPrefab, new Vector3(xPos, 1, 8f), Quaternion.identity);

        obj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -moveSpeed); // Move down towards the player
    }
}