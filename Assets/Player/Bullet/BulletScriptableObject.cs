using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName ="Player/BulletData")]
public class BulletScriptableObject : ScriptableObject
{
    [SerializeField] int damage = 1;
    [SerializeField] float speed = 40;

    public int Damage { get => damage; set => damage = value; }
    public float Speed { get => speed; set => speed = value; }
}
