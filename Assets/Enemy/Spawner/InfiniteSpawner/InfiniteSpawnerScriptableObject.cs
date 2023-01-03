using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfiniteSpawnerData", menuName = "Spawner/InfiniteSpawnerData")]
public class InfiniteSpawnerScriptableObject : SpawnerScriptableObject
{
    [SerializeField] float minRandomTime;
    [SerializeField] float maxRandomTime;


    public float MinRandomTime { get => minRandomTime; set => minRandomTime = value; }
    public float MaxRandomTime { get => maxRandomTime; set => maxRandomTime = value; }
}
