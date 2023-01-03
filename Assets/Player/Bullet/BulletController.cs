using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] BulletScriptableObject bulletData;
    [SerializeField] GameObject bulletCollisionParticle;
    private void Start()
    {
        Invoke("DestroyBullet", 90 / bulletData.Speed);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * bulletData.Speed * Time.deltaTime);
    }/*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().Damage(bulletData.Damage);
            Destroy(gameObject);
        }
        else 
        {
            MissCount.Instance.ChangeMissCount(1);
            Destroy(gameObject);
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().Damage(bulletData.Damage);
            Instantiate(bulletCollisionParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            MissCount.Instance.ChangeMissCount(1);
            Destroy(gameObject);
        }
    }
    private void DestroyBullet()
    {
        Destroy(gameObject);
        MissCount.Instance.ChangeMissCount(1);
    }
}
