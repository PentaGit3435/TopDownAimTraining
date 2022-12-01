using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnvironmentData",menuName = "EnvironmentData")]
public class EnvironmentScriptableObject : ScriptableObject
{
    //---ENVIRONMENT_SCENE---//
    [SerializeField] float cameraView = 20;
    [SerializeField] bool haveTimeLimit;
    [SerializeField] int min = 1;
    [SerializeField] int seg = 0;

    //--SPAWNER--//
    [SerializeField] SpawnerTipe spawner1Type = SpawnerTipe.InfinitySpawner;
    [SerializeField] SpawnerTipe spawner2Type = SpawnerTipe.InfinitySpawner;
    [SerializeField] SpawnerTipe spawner3Type = SpawnerTipe.Disabled;





    public float CameraView { get => cameraView; set => cameraView = value; }
    public bool HaveTimeLimit { get => haveTimeLimit; set => haveTimeLimit = value; }
    public int Min { get => min; set => min = value; }
    public int Seg { get => seg; set => seg = value; }
    public SpawnerTipe Spawner1Type { get => spawner1Type; set => spawner1Type = value; }
    public SpawnerTipe Spawner2Type { get => spawner2Type; set => spawner2Type = value; }
    public SpawnerTipe Spawner3Type { get => spawner3Type; set => spawner3Type = value; }

    public enum SpawnerTipe 
    {
        InfinitySpawner,
        FinitySpawner,
        Disabled
    }
}
