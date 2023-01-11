using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnerSettingController : MonoBehaviour
{
    [SerializeField] TMP_Dropdown spawnerTipeDropdown;

    [Header("InfinitySpawner")]
    [SerializeField] GameObject infinitySpawnerSettings;
    [SerializeField] TMP_InputField minSpawnTimeInputField;
    [SerializeField] TMP_InputField maxSpawnTimeInputField;
    [SerializeField] Toggle StaticTarget;
    [SerializeField] Toggle MoveTarget;
    [SerializeField] Toggle RandomMoveTarget;
    [SerializeField] Toggle teleportTarget;
    //data
    [SerializeField] InfiniteSpawnerScriptableObject infiniteSpawnerScriptableObject;

    [Header("FinitySpawner")]
    [SerializeField] GameObject finitySpawnerSettings;
    [SerializeField] GameObject enemysList;
    [SerializeField] GameObject addEnemyButton;
    [SerializeField] GameObject removeEnemyButton;
    [SerializeField] GameObject scroll;
    [SerializeField] GameObject enemy;
    [SerializeField] TMP_InputField startTime;
    [SerializeField] TMP_InputField repeatTime;
    [SerializeField] Transform targets;
    //data
    [SerializeField] FiniteSpawnerScriptableObject finiteSpawnerScriptableObject;


    [Header("TargetPrefab")] 
    [SerializeField] GameObject StaticTargetPrefab;
    [SerializeField] GameObject MoveTargetPrefab;
    [SerializeField] GameObject RandomMoveTargetPrefab;
    [SerializeField] GameObject teleportTargetPrefab;


    List<GameObject> listVacio = new List<GameObject>();
    private void Start()
    {
        SetSpawnerData();
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
    void SetSpawnerData()
    {
        // SpawnerTypes //
        if (infiniteSpawnerScriptableObject.Active == true)//infiniteSpawner
        {
            spawnerTipeDropdown.value = 0;

            minSpawnTimeInputField.text = infiniteSpawnerScriptableObject.MinRandomTime.ToString();
            maxSpawnTimeInputField.text = infiniteSpawnerScriptableObject.MaxRandomTime.ToString();

            StaticTarget.isOn = false;
            MoveTarget.isOn = false;
            RandomMoveTarget.isOn = false;
            teleportTarget.isOn = false;
            foreach (GameObject target in infiniteSpawnerScriptableObject.EnemysList)
            {
                switch (target.name)
                {
                    case "BasicEnemy":
                        StaticTarget.isOn = true;
                        break;
                    case "MoveForwardEnemy":
                        MoveTarget.isOn = true;
                        break;
                    case "RandomMoveEnemy":
                        RandomMoveTarget.isOn = true;
                        break;
                    case "TeleportEnemy":
                        teleportTarget.isOn = true;
                        break;
                }
            }
        }
        else//finiteSpawner
        {
            spawnerTipeDropdown.value = 1;

            startTime.text = finiteSpawnerScriptableObject.StartTime.ToString();
            repeatTime.text = finiteSpawnerScriptableObject.RepeatTime.ToString();

            //Debug.Log(enemysList.transform.childCount > 0);
            if (finiteSpawnerScriptableObject.EnemysList.Count > 0)
            {
                while (enemysList.transform.childCount > 0)
                {
                    DestroyImmediate(enemysList.transform.GetChild(0).gameObject);
                }
            }

            foreach (GameObject target in finiteSpawnerScriptableObject.EnemysList)
            {
                switch (target.name)
                {
                    case "BasicEnemy":
                        Instantiate(enemy, enemysList.transform).GetComponent<TMP_Dropdown>().value = 0;
                        break;
                    case "MoveForwardEnemy":
                        Instantiate(enemy, enemysList.transform).GetComponent<TMP_Dropdown>().value = 1;
                        break;
                    case "RandomMoveEnemy":
                        Instantiate(enemy, enemysList.transform).GetComponent<TMP_Dropdown>().value = 2;
                        break;
                    case "TeleportEnemy":
                        Instantiate(enemy, enemysList.transform).GetComponent<TMP_Dropdown>().value = 3;
                        break;
                }
            }
        }

    }

    //infinitySpawnerMethods
    public void MaxSpawnTimeInputField()
    {
        if (minSpawnTimeInputField.text == "" || maxSpawnTimeInputField.text == "") return;

        if (float.Parse(minSpawnTimeInputField.text) > float.Parse(maxSpawnTimeInputField.text))
        {
            maxSpawnTimeInputField.text = float.Parse(minSpawnTimeInputField.text) + 1 + "";
        }
    }

    //finitySpawnerMethods
    public void SelectEnemysButton()
    {
        if (scroll.activeSelf)
        {
            //enemysList.SetActive(false);
            addEnemyButton.SetActive(false);
            removeEnemyButton.SetActive(false);
            scroll.SetActive(false);
        }
        else
        {
            //enemysList.SetActive(true);
            addEnemyButton.SetActive(true);
            removeEnemyButton.SetActive(true);
            scroll.SetActive(true);
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

    //save
    public void Save() 
    {
        //spawner type
        if(spawnerTipeDropdown.value == 0)//InfiniteSpawner
        {
            infiniteSpawnerScriptableObject.Active = true;
            finiteSpawnerScriptableObject.Active = false;

            //time
            infiniteSpawnerScriptableObject.MinRandomTime = float.Parse(minSpawnTimeInputField.text);
            infiniteSpawnerScriptableObject.MaxRandomTime = float.Parse(maxSpawnTimeInputField.text);

            //targets
            infiniteSpawnerScriptableObject.EnemysList = listVacio;
            if(StaticTarget.isOn == true)
            {
                infiniteSpawnerScriptableObject.EnemysList.Add(StaticTargetPrefab);
            }
            if(MoveTarget.isOn == true)
            {
                infiniteSpawnerScriptableObject.EnemysList.Add(MoveTargetPrefab);
            }
            if(RandomMoveTarget.isOn == true)
            {
                infiniteSpawnerScriptableObject.EnemysList.Add(RandomMoveTargetPrefab);
            }
            if(teleportTarget.isOn == true)
            {
                infiniteSpawnerScriptableObject.EnemysList.Add(teleportTargetPrefab);
            }
        }
        else //finite spawner
        {
            infiniteSpawnerScriptableObject.Active = false;
            finiteSpawnerScriptableObject.Active = true;

            //time
            finiteSpawnerScriptableObject.StartTime = float.Parse(startTime.text);
            finiteSpawnerScriptableObject.RepeatTime = float.Parse(repeatTime.text);

            //targets
            finiteSpawnerScriptableObject.EnemysList = listVacio;
            for(int i = 0; i < targets.childCount; i++)
            {
                int targetTypeValue = targets.GetChild(i).GetComponent<TMP_Dropdown>().value;
                switch (targetTypeValue)
                {
                    case 0:
                        finiteSpawnerScriptableObject.EnemysList.Add(StaticTargetPrefab);
                        break;

                    case 1:
                        finiteSpawnerScriptableObject.EnemysList.Add(MoveTargetPrefab);
                        break;

                    case 2:
                        finiteSpawnerScriptableObject.EnemysList.Add(RandomMoveTargetPrefab);
                        break;

                    default:
                        finiteSpawnerScriptableObject.EnemysList.Add(teleportTargetPrefab);
                        break;
                }
            }
        }
    }
}
