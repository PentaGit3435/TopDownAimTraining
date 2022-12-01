using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FiniteSpawnerData", menuName = "Spawner/FiniteSpawnerData")]
public class FiniteSpawnerScriptableObject : SpawnerScriptableObject
{
    [SerializeField] float startTime;
    [SerializeField] float repeatTime;


    public float StartTime { get => startTime; set => startTime = value; }
    public float RepeatTime { get => repeatTime; set => repeatTime = value; }
}
