using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveEnemyData", menuName = "Enemy/MoveEnemyData")]
public class MoveEnemyScriptableObject : EnemyScriptableObject
{
    [SerializeField] float speed;

    public float Speed { get => speed; set => speed = value; }
}
