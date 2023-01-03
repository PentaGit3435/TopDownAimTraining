using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    [SerializeField] GameObject TimeOutPanel;

    public static bool IsTimeOut { get; private set; }

    TextMeshProUGUI textMeshProUGUI;
    float seg;
    private void Awake()
    {
        IsTimeOut = false;
        if (!environmentScriptableObject.HaveTimeLimit)
        {
            DestroyImmediate(this);
        }
    }
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        seg = environmentScriptableObject.Min * 60 + environmentScriptableObject.Seg;
    }
    void Update()
    {
        if(seg <= 0 && !IsTimeOut)
        {
            TimeOut();
        }
        seg -= Time.deltaTime;
        textMeshProUGUI.text = SegToMinSeg(seg);
    }
    string SegToMinSeg(float time)
    {
        float min;
        float seg;
        min = (int)time / 60;
        seg = (int)time % 60;
        return min + " : " + seg;
    }
    void TimeOut()
    {
        //pause
        Time.timeScale = 0;
        //active time out panel
        TimeOutPanel.SetActive(true);
        //set bool
        IsTimeOut = true;
    }
}
