using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RandomMoveEnemyData", menuName = "Enemy/RandomMoveEnemyData")]
[SerializeField]
public class RandomMoveEnemyScriptableObject : NeedRandomPointEnemyScriptableObject
{
    [SerializeField] float speed = 10f;

    public float Speed { get => speed; set => speed = value; }
}
