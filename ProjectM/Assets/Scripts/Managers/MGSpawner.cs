using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGSpawner : MonoBehaviour
{
    public Transform spawnPos;
    public float randomSpawnAmount = 1.0f;

    float lastSpawnTime = float.MinValue;
    float spanwDelay = 1.0f;

    private void Start()
    {
        spawnPos = GameObject.Find("SpawnPoint").transform;
    }

    // void Update()
    // {
    //     if(Time.time < lastSpawnTime + spanwDelay) return;
    //     lastSpawnTime = Time.time;

    //     spawnPos.position = new Vector2(spawnPos.position.x, Random.Range(spawnPos.position.y - randomSpawnAmount, spawnPos.position.y + randomSpawnAmount));
        
    //     MGGame.Instance.SpawEnemy(spawnPos.position, EnemyType.NORMAL);
    // }
}
