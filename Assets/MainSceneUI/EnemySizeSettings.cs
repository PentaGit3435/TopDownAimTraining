using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySizeSettings : MonoBehaviour
{
    [SerializeField] Slider SizeSlider;

    public void OnSizeSliderChanged()
    {
        transform.localScale = Vector3.one * SizeSlider.value;
    }
}
