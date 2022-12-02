using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FiniteSpawnerData", menuName = "Spawner/FiniteSpawnerData")]
public class FiniteSpawnerScriptableObject : SpawnerScriptableObject
{
    bool active;
    [SerializeField] float startTime;
    [SerializeField] float repeatTime;


    public bool Active { get => active; set => active = value; }
    public float StartTime { get => startTime; set => startTime = value; }
    public float RepeatTime { get => repeatTime; set => repeatTime = value; }
}
