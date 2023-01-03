using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    [SerializeField] Transform player;
    void Awake()
    {
        Camera.main.orthographicSize = environmentScriptableObject.CameraView;
        transform.LookAt(player);
    }
}
