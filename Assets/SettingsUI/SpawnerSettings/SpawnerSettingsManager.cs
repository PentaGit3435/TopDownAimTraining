using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnerSettingsManager : MonoBehaviour
{
    [SerializeField] Slider setSpawnerNumSlider;
    [SerializeField] GameObject setting1;
    [SerializeField] GameObject setting2;
    [SerializeField] GameObject setting3;

    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData1;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData2;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData3;

    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData1;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData2;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData3;


    private void Start()
    {
        OnSpawnerNumSliderChanged();
    }
    public void OnSpawnerNumSliderChanged()
    {
        if (setSpawnerNumSlider.value == 1)
        {
            setting1.SetActive(true);
            setting2.SetActive(false);
            setting3.SetActive(false);
        }
        else if (setSpawnerNumSlider.value == 2)
        {
            setting1.SetActive(true);
            setting2.SetActive(true);
            setting3.SetActive(false);
        }
        else
        {
            setting1.SetActive(true);
            setting2.SetActive(true);
            setting3.SetActive(true);
        }
    }



    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(2);
    }
    public void Save()
    {

    }
}
