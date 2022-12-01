using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitCount : PointCount
{
    public static HitCount Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void ChangeHitCount(int amount)
    {
        point += amount;
        SetText();
    }
}
