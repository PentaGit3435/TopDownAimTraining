using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveEnemy : NeedRandomPointEnemy
{
    Vector3 randomDirection;
    void Start()
    {
        InvokeRepeating("SetRandomDirection", 0, needRandomPointEnemyData.SetRandomPointTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(randomDirection * 10 * Time.deltaTime);
    }
    private void SetRandomDirection()
    {
        randomDirection = (GetRadomPoint() - transform.position).normalized;
    }
    protected override Vector3 GetRadomPoint()
    {
        return new Vector3(Random.Range(vertice1.position.x/0.12f, vertice2.position.x/0.12f), transform.position.y, Random.Range(vertice1.position.z/0.12f, vertice2.position.z/0.12f));
    }
}
