using UnityEngine;
using System.Collections;
/// <summary>
/// This is a simple spawner script allowing the enemy to spawn from spawn point loactions around the mao
/// </summary>
public class EnemySoldierSpawn : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public float SpawnRate = 1.0f;
    float spawnTimer;




    void Awake()
    {

    }


    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= SpawnRate)
        {
            GameObject Enemy = Instantiate(EnemyPrefab, transform.position, transform.rotation) as GameObject;


            spawnTimer = 0.5f;
        }
    }
}
