using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEnemy : NeedRandomPointEnemy
{
    void Start()
    {
        InvokeRepeating("Teleport", needRandomPointEnemyData.SetRandomPointTime, needRandomPointEnemyData.SetRandomPointTime);

    }
    void Teleport()
    {
        transform.position = GetRadomPoint();
    }
}
