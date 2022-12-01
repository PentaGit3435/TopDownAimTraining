using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerData", menuName ="Spawner/SpawnerData")]
public class SpawnerScriptableObject : ScriptableObject
{
    [SerializeField] GameObject[] enemysList;

    public GameObject[] EnemysList { get => enemysList; set => enemysList = value; }
}
