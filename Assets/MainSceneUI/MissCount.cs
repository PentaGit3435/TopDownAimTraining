using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissCount : PointCount
{
    public static MissCount Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void ChangeMissCount(int amount)
    {
        point += amount;
        SetText();
    }
}
