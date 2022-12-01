using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCount : MonoBehaviour
{
    protected int point = 0;
    protected TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    protected void SetText()
    {
        textMesh.text = point.ToString();
    }
}
