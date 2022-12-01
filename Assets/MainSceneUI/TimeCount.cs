using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TimeCount : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        textMeshProUGUI.text = SegToMinSeg(Time.realtimeSinceStartup);
    }
    string SegToMinSeg(float time)
    {
        float min;
        float seg;
        min = (int)time / 60;
        seg = (int)time % 60;
        return min + " : " + seg;
    }
}
