using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<SpawnableEnemyInfo> spawnableEnemies;
    private Dictionary<SpawnableEnemyInfo, float> spawnTimer;
    private GameObject player;
    [SerializeField]
    private float spawnDistance = 10;

	private void Start()
	{
        spawnTimer = new();
        player = GameObject.Find("Player");
	}

	void Update()
    {
        foreach (SpawnableEnemyInfo spawnable in spawnableEnemies)
        {
            if (spawnTimer.ContainsKey(spawnable))
            {
                spawnTimer[spawnable] += Time.deltaTime * GameManager.Instance.GameSpeed;
                if (spawnTimer[spawnable] > 1f / spawnable.SpawnFrequency)
                {
                    int numberToSpawn = Random.Range(spawnable.minNumForGroupSpawns, spawnable.maxNumForGroupSpawns);

                    Vector3 spawnPos = new(Random.Range(-1f,1f), Random.Range(-1f, 1f), 0);
                    spawnPos = spawnPos.normalized;
                    spawnPos = player.transform.position + spawnPos * spawnDistance;

                    for (int i = 0; i < numberToSpawn; i++)
                    {
                        Vector3 thisSpawnPos = spawnPos + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);

						Instantiate(spawnable.prefab, thisSpawnPos, Quaternion.identity);
                    }
                }
            }
            else
            {
                spawnTimer.Add(spawnable, 0);
            }
        }
    }
}
