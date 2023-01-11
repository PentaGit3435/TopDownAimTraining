using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnerSettingsManager : MonoBehaviour
{
    [SerializeField] Slider setSpawnerNumSlider;

    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;

    [Header("settings1")]
    [SerializeField] GameObject setting1GameObject;
    //[SerializeField] InfiniteSpawnerScriptableObject infiniteSpawner1ScriptableObject;
    //[SerializeField] FiniteSpawnerScriptableObject finiteSpawner1ScriptableObject;
                                        
                                        
    [Header("settings2")]               
    [SerializeField] GameObject setting2GameObject;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawner2ScriptableObject;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawner2ScriptableObject;


    [Header("settings3")]               
    [SerializeField] GameObject setting3GameObject;
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawner3ScriptableObject;
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawner3ScriptableObject;

    private void Start()
    {
        SetNumSpawnerSliderData();
        OnSpawnerNumSliderChanged();
    }
    //on spawner num slider change
    public void OnSpawnerNumSliderChanged()
    {
        if (setSpawnerNumSlider.value == 1)
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(false);
            setting3GameObject.SetActive(false);

            //spawnerData
            infiniteSpawner2ScriptableObject.Active = false;
            finiteSpawner2ScriptableObject.Active = false;

            infiniteSpawner3ScriptableObject.Active = false;
            finiteSpawner3ScriptableObject.Active = false;
        }
        else if (setSpawnerNumSlider.value == 2)
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(false);

            //spawnerData
            infiniteSpawner3ScriptableObject.Active = false;
            finiteSpawner3ScriptableObject.Active = false;
        }
        else
        {
            setting1GameObject.SetActive(true);
            setting2GameObject.SetActive(true);
            setting3GameObject.SetActive(true);
        }
    }

    //setData
    void SetNumSpawnerSliderData()
    {
        if (infiniteSpawner2ScriptableObject.Active == false && finiteSpawner2ScriptableObject.Active == false && infiniteSpawner3ScriptableObject.Active == false && finiteSpawner3ScriptableObject.Active == false)
        {
            setSpawnerNumSlider.value = 1;
        }
        else if (infiniteSpawner3ScriptableObject.Active == false && finiteSpawner3ScriptableObject.Active == false)
        {
            setSpawnerNumSlider.value = 2;
        }
        else
        {
            setSpawnerNumSlider.value = 3;
        }
    }

    //changeScene
    public void NextScene()
    {
        SceneManager.LoadScene(1);
        //all configured
        environmentScriptableObject.Configured = true;
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(2);
    }

    //save
    public void SaveSpawnerAmount()
    {
        if (setSpawnerNumSlider.value == 1)
        {
            infiniteSpawner2ScriptableObject.Active = false;
            finiteSpawner2ScriptableObject.Active = false;

            infiniteSpawner3ScriptableObject.Active = false;
            finiteSpawner3ScriptableObject.Active = false;
        }
        else if (setSpawnerNumSlider.value == 2)
        {
            infiniteSpawner3ScriptableObject.Active = false;
            finiteSpawner3ScriptableObject.Active = false;
        }
    }
}
