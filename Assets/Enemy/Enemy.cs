using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]EnemyScriptableObject enemyData;
    int hp;

    private void OnEnable()
    {
        hp = enemyData.Hp; 
        SetSize();
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
    public void SetSize()
    {
        transform.localScale = Vector3.one * enemyData.Size;
    }
}
