using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerArea : MonoBehaviour
{

    void Start()
    {
        transform.localScale *= Camera.main.orthographicSize;
    }
}
