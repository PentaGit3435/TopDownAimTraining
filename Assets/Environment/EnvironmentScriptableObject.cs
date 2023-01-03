using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnvironmentData",menuName = "EnvironmentData")]
public class EnvironmentScriptableObject : ScriptableObject
{
    [SerializeField] float cameraView = 20;
    [SerializeField] bool haveTimeLimit;
    [SerializeField] int min = 1;
    [SerializeField] int seg = 0;
    [SerializeField] bool configured;




    public float CameraView { get => cameraView; set => cameraView = value; }
    public bool HaveTimeLimit { get => haveTimeLimit; set => haveTimeLimit = value; }
    public int Min { get => min; set => min = value; }
    public int Seg { get => seg; set => seg = value; }
    public bool Configured { get => configured; set => configured = value; }
}
