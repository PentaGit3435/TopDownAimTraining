using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerData", menuName ="Spawner/SpawnerData")]
public class SpawnerScriptableObject : ScriptableObject
{
    [SerializeField] bool active = false;
    [SerializeField] List<GameObject> enemysList = new List<GameObject>();



    public bool Active { get => active; set => active = value; }
    public List<GameObject> EnemysList { get => enemysList; set => enemysList = value; }
}
