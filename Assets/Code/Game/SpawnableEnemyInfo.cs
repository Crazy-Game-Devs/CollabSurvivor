using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spawn Enemy Info", menuName = "Spawn Enemy Info")]
public class SpawnableEnemyInfo : ScriptableObject
{
    public GameObject prefab;
    public float SpawnFrequency;
    public int minNumForGroupSpawns;
    public int maxNumForGroupSpawns;
}
