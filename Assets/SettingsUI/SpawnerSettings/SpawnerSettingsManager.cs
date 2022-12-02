using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnerSettingsManager : MonoBehaviour
{
    [SerializeField] Slider setSpawnerNumSlider;

    
    [Header("settings1")]
    [SerializeField] GameObject setting1GameObject;
    [SerializeField] Dropdown spawerType1Dropdown;
    //data                              
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData1;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData1;
                                        
                                        
    [Header("settings2")]               
    [SerializeField] GameObject setting2GameObject;
    [SerializeField] Dropdown spawerType2Dropdown;
    //data                              
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData2;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData2;
                                        
                                        
    [Header("settings3")]               
    [SerializeField] GameObject setting3GameObject;
    [SerializeField] Dropdown spawerType3Dropdown;
    //data
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerData3;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerData3;


    private void Start()
    {
        OnSpawnerNumSliderChanged();
    }
    public void OnSpawnerNumSliderChanged()
    {
        if (setSpawnerNumSlider.value == 1)
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(false);
            setting3GameObject.SetActive(false);
        }
        else if (setSpawnerNumSlider.value == 2)
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(false);
        }
        else
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(true);
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
        if (setSpawnerNumSlider.value == 1)
        {
            if(spawerType1Dropdown.value == 0)
        }
        else if (setSpawnerNumSlider.value == 2)
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(false);
        }
        else
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(true);
        }
    }
}
