using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfiniteSpawnerData", menuName = "Spawner/InfiniteSpawnerData")]
public class InfiniteSpawnerScriptableObject : SpawnerScriptableObject
{
    [SerializeField] float randomSpawnTime1;
    [SerializeField] float randomSpawnTime2;

    public float RandomSpawnTime1 { get => randomSpawnTime1; set => randomSpawnTime1 = value; }
    public float RandomSpawnTime2 { get => randomSpawnTime2; set => randomSpawnTime2 = value; }
}
