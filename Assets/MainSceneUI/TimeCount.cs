using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCount : MonoBehaviour
{
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    TextMeshProUGUI textMeshProUGUI;
    float time;
    private void Awake()
    {
        if (environmentScriptableObject.HaveTimeLimit)
        {
            DestroyImmediate(this);
        }
    }
    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        time = 0;
    }
    void Update()
    {
        time += Time.deltaTime;
        textMeshProUGUI.text = SegToMinSeg(time);
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
