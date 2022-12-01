using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class SpawnerSettingController : MonoBehaviour
{

    [SerializeField] TMP_Dropdown spawnerTipeDropdown;

    [Header("InfinitySpawner")]
    [SerializeField] GameObject infinitySpawnerSettings;
    [SerializeField] TMP_InputField minSpawnTimeInputField;
    [SerializeField] TMP_InputField maxSpawnTimeInputField;

    [Header("FinitySpawner")]
    [SerializeField] GameObject finitySpawnerSettings;
    [SerializeField] GameObject enemysList;
    [SerializeField] GameObject addEnemyButton;
    [SerializeField] GameObject removeEnemyButton;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        SpawnerTypeDropdownController();
    }

    public void SpawnerTypeDropdownController()
    {
        if (spawnerTipeDropdown.value == 0)
        {
            infinitySpawnerSettings.SetActive(true);
            finitySpawnerSettings.SetActive(false);
        }
        else
        {
            infinitySpawnerSettings.SetActive(false);
            finitySpawnerSettings.SetActive(true);
        }
    }

    //infinitySpawnerMethods
    public void MaxSpawnTimeInputField()
    {
        if (minSpawnTimeInputField.text == "" || maxSpawnTimeInputField.text == "") return;

        if (int.Parse(minSpawnTimeInputField.text) > int.Parse(maxSpawnTimeInputField.text))
        {
            maxSpawnTimeInputField.text = int.Parse(minSpawnTimeInputField.text) + 1 + "";
        }
    }

    //finitySpawnerMethods
    public void SelectEnemysButton()
    {
        if (enemysList.activeSelf)
        {
            enemysList.SetActive(false);
            addEnemyButton.SetActive(false);
            removeEnemyButton.SetActive(false);
        }
        else
        {
            enemysList.SetActive(true);
            addEnemyButton.SetActive(true);
            removeEnemyButton.SetActive(true);
        }
    }
    public void OnPlusButtonActive()
    {
        Instantiate(enemy, enemysList.transform);
    }
    public void OnMinusButtonActive()
    {
        if (enemysList.transform.childCount > 1)
        {
            Destroy(enemysList.transform.GetChild(enemysList.transform.childCount - 1).gameObject);
        }
    }
}
