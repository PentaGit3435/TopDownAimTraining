using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedRandomPointEnemy : Enemy
{
    protected Transform vertice1;
    protected Transform vertice2;
    [SerializeField] protected NeedRandomPointEnemyScriptableObject needRandomPointEnemyData;
    private void Awake()
    {
        vertice1 = GameObject.FindGameObjectWithTag("Vertice1").transform;
        vertice2 = GameObject.FindGameObjectWithTag("Vertice2").transform;
    }
    protected virtual Vector3 GetRadomPoint()
    {
        return new Vector3(Random.Range(vertice1.position.x, vertice2.position.x), transform.position.y, Random.Range(vertice1.position.z, vertice2.position.z));
    }
}
