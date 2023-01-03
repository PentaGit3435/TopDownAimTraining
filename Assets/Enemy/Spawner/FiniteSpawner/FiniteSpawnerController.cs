using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteSpawnerController : MonoBehaviour
{
    [SerializeField] FiniteSpawnerScriptableObject spawnerData;
    [SerializeField] Transform vertice1;
    [SerializeField] Transform vertice2;

    Queue enemys;

    private void OnEnable()
    {
        if (!spawnerData.Active) Destroy(this.gameObject);
    }
    void Start()
    {
        enemys = new Queue(spawnerData.EnemysList);
        InvokeRepeating("InstantiateEnemy",spawnerData.StartTime, spawnerData.RepeatTime);
    }
    void InstantiateEnemy()
    {
        if (enemys.Count != 0)
        {
            Instantiate(enemys.Dequeue() as GameObject, new Vector3(Random.Range(vertice1.position.x, vertice2.position.x), 1, Random.Range(vertice1.position.z, vertice2.position.z)), Quaternion.Euler(0, Random.Range(0f, 360), 0));
        }
        else Destroy(gameObject);
    }
}
