using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float spawnRange = 5f;

    private float timer = 0f;

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnMonster();
            timer = 0f;
        }
    }

    public void SpawnMonster()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), transform.position.y, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}