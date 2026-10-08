using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            float randomXPos = Random.Range(24.02f, -24.02f);
            float randomYPos = Random.Range(14.95f, -14.95f);
            Vector2 spawnPosition = new Vector2(randomXPos, randomYPos);
            Instantiate(enemy, spawnPosition, transform.rotation);
            yield return new WaitForSeconds(1f);
        }
    }
}
