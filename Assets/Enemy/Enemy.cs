using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]EnemyScriptableObject enemyData;
    int hp;

    private void Awake()
    {
        hp = enemyData.Hp;
        transform.localScale = new Vector3(enemyData.Size, enemyData.Size, enemyData.Size);
        Invoke("EnemyTimeLimit", enemyData.TimeLimit);
    }
    public void Damage(int damage)
    {
        hp -= damage;
        Dead();
    }
    void Dead()
    {
        if(hp <= 0)
        {
            HitCount.Instance.ChangeHitCount(1);
            Destroy(gameObject);
        }
    }
    private void EnemyTimeLimit()
    {
        MissCount.Instance.ChangeMissCount(1);
        Destroy(gameObject);
    }
}
