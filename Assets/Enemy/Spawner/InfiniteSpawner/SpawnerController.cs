using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] InfiniteSpawnerScriptableObject spawnerData;
    [SerializeField] Transform vertice1;
    [SerializeField] Transform vertice2;
    private void OnEnable()
    {
        if (!spawnerData.Active) Destroy(this.gameObject);
    }
    void Start()
    {
        InstantiateEnemys();
    }
    void InstantiateEnemys()
    {
        Instantiate(spawnerData.EnemysList[Random.Range(0,spawnerData.EnemysList.Count)], new Vector3(Random.Range(vertice1.position.x, vertice2.position.x), 1, Random.Range(vertice1.position.z, vertice2.position.z)), Quaternion.Euler(0, Random.Range(0f, 360), 0));

        Invoke("InstantiateEnemys", Random.Range(spawnerData.MinRandomTime, spawnerData.MaxRandomTime));
    }
}
