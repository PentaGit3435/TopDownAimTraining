using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveEnemy : NeedRandomPointEnemy
{
    [SerializeField] RandomMoveEnemyScriptableObject randomMoveEnemyScriptableObject;

    Vector3 randomPoint;
    void Start()
    {
        randomPoint = GetRadomPoint();
    }

    void Update()
    {
        if(Mathf.RoundToInt(randomPoint.x) == Mathf.RoundToInt(transform.position.x) && Mathf.RoundToInt(randomPoint.z) == Mathf.RoundToInt(transform.position.z))
        {
            randomPoint = GetRadomPoint();
        }
        MoveTo();
    }
    private void MoveTo()
    {
        transform.position += (randomPoint - transform.position).normalized * randomMoveEnemyScriptableObject.Speed * Time.deltaTime;
    }
}
