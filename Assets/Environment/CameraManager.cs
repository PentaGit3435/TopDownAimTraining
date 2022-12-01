using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]Transform player;
    void Start()
    {
        transform.LookAt(player);
    }
}
