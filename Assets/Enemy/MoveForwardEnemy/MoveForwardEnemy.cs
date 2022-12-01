using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardEnemy : Enemy
{
    [SerializeField] MoveEnemyScriptableObject moveEnemyForwardData;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * moveEnemyForwardData.Speed, ForceMode.Impulse);
    }
    void Update()
    {
        //transform.Translate(Vector3.forward * moveEnemyForwardData.Speed * Time.deltaTime);
    }/*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("WorldLimitWall"))
        {
            if(collision.transform.rotation.eulerAngles.y == 0)
            {
                transform.rotation = Quaternion.Euler(0, Random.Range(100f, 260f), 0);
            }
            else if(collision.transform.rotation.eulerAngles.y == 90)
            {
                transform.rotation = Quaternion.Euler(0, Random.Range(100f + 90f, 260f + 90f), 0);
            }
            else if (collision.transform.rotation.eulerAngles.y == 90 + 90)
            {
                transform.rotation = Quaternion.Euler(0, Random.Range(100f + 90f + 90, 260f + 90f + 90), 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, Random.Range(10f, 170f), 0);
            }
        }
    }*/
}
