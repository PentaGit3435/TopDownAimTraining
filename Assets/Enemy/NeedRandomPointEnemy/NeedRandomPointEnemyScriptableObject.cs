using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NeedRandomPointEnemyData", menuName = "Enemy/NeedRandomPointEnemyData")]
public class NeedRandomPointEnemyScriptableObject : EnemyScriptableObject
{
    [SerializeField] float setRandomPointTime;

    public float SetRandomPointTime { get => setRandomPointTime; set => setRandomPointTime = value; }
}
