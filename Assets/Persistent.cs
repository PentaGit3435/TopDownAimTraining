using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistent : MonoBehaviour
{
    [Header("Target ScriptableObject")]
    [SerializeField] EnemyScriptableObject enemyScriptableObject;
    [SerializeField] MoveEnemyScriptableObject moveEnemyScriptableObject;
    [SerializeField] RandomMoveEnemyScriptableObject randomMoveEnemyScriptableObject;
    [SerializeField] NeedRandomPointEnemyScriptableObject teleportEnemyScriptableObject;

    [Header("Spawner ScriptableObject")]
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerScriptableObject1;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerScriptableObject2;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerScriptableObject3;

    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerScriptableObject1;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerScriptableObject2;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerScriptableObject3;

    [Header("Environment ScriptableObject")]
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    

        //--DataFileName--//
    //Target
    string staticEnemyFileName = "StaticEnemy.json";
    string moveEnemyFileName = "MoveEnemy.json";
    string randomMoveEnemyFileName = "RandomMoveEnemy.json";
    string teleportEnemyFileName = "TeleportEnemy.json";

    //Spawner
    string infiniteSpawner1FileName = "InfiniteSpawner_1.json";
    string infiniteSpawner2FileName = "InfiniteSpawner_2.json";
    string infiniteSpawner3FileName = "InfiniteSpawner_3.json";

    string finiteSpawner1FileName = "FiniteSpawner_1.json";
    string finiteSpawner2FileName = "FiniteSpawner_2.json";
    string finiteSpawner3FileName = "FiniteSpawner_3.json";

    //Environment
    string environmentFileName = "Environment.json";




    public static Persistent persistent;
    private void Awake()
    {
        if (persistent == null)
        {
            persistent = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
        //Target
        SaveLoad.Load<EnemyScriptableObject>(staticEnemyFileName, enemyScriptableObject);
        SaveLoad.Load<MoveEnemyScriptableObject>(moveEnemyFileName, moveEnemyScriptableObject);
        SaveLoad.Load<RandomMoveEnemyScriptableObject>(randomMoveEnemyFileName, randomMoveEnemyScriptableObject);
        SaveLoad.Load<NeedRandomPointEnemyScriptableObject>(teleportEnemyFileName, teleportEnemyScriptableObject);

        //Spawner
        SaveLoad.Load<InfiniteSpawnerScriptableObject>(infiniteSpawner1FileName, infiniteSpawnerScriptableObject1);
        SaveLoad.Load<InfiniteSpawnerScriptableObject>(infiniteSpawner2FileName, infiniteSpawnerScriptableObject2);
        SaveLoad.Load<InfiniteSpawnerScriptableObject>(infiniteSpawner3FileName, infiniteSpawnerScriptableObject3);
        SaveLoad.Load<FiniteSpawnerScriptableObject>(finiteSpawner1FileName, finiteSpawnerScriptableObject1);
        SaveLoad.Load<FiniteSpawnerScriptableObject>(finiteSpawner2FileName, finiteSpawnerScriptableObject2);
        SaveLoad.Load<FiniteSpawnerScriptableObject>(finiteSpawner3FileName, finiteSpawnerScriptableObject3);

        //Environment
        SaveLoad.Load<EnvironmentScriptableObject>(environmentFileName, environmentScriptableObject);
    }
    private void OnApplicationQuit()
    {
        //Target
        SaveLoad.Save<EnemyScriptableObject>(staticEnemyFileName, enemyScriptableObject);
        SaveLoad.Save<MoveEnemyScriptableObject>(moveEnemyFileName, moveEnemyScriptableObject);
        SaveLoad.Save<RandomMoveEnemyScriptableObject>(randomMoveEnemyFileName, randomMoveEnemyScriptableObject);
        SaveLoad.Save<NeedRandomPointEnemyScriptableObject>(teleportEnemyFileName, teleportEnemyScriptableObject);

        //Spawner
        SaveLoad.Save<InfiniteSpawnerScriptableObject>(infiniteSpawner1FileName, infiniteSpawnerScriptableObject1);
        SaveLoad.Save<InfiniteSpawnerScriptableObject>(infiniteSpawner2FileName, infiniteSpawnerScriptableObject2);
        SaveLoad.Save<InfiniteSpawnerScriptableObject>(infiniteSpawner3FileName, infiniteSpawnerScriptableObject3);
        SaveLoad.Save<FiniteSpawnerScriptableObject>(finiteSpawner1FileName, finiteSpawnerScriptableObject1);
        SaveLoad.Save<FiniteSpawnerScriptableObject>(finiteSpawner2FileName, finiteSpawnerScriptableObject2);
        SaveLoad.Save<FiniteSpawnerScriptableObject>(finiteSpawner3FileName, finiteSpawnerScriptableObject3);

        //Environment
        SaveLoad.Save<EnvironmentScriptableObject>(environmentFileName, environmentScriptableObject);
    }
}
