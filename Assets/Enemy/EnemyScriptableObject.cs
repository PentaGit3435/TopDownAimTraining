using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "EnemyData", menuName = "Enemy/EnemyData")]
[SerializeField]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] int hp = 1;
    [SerializeField] float timeLimit = Mathf.Infinity;
    [SerializeField] float size = 4;



    public int Hp { get => hp; set => hp = value; }
    public float TimeLimit { get => timeLimit; set => timeLimit = value; }
    public float Size { get => size; set => size = value; }
}
