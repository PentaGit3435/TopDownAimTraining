using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfItsConfigured : MonoBehaviour
{
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    [SerializeField] bool configured = true;
    void Awake()
    {
        if (environmentScriptableObject.Configured == configured)
        {
            Destroy(this.gameObject);
        }
        else Destroy(this);
    }
}
