using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TargetSettingsManager : MonoBehaviour
{
    [Header("StaticTarget")]
    [SerializeField] private TMP_InputField staticTargetHPInputField;
    [SerializeField] private TMP_InputField staticTargetTimeLimitInputField;
    [SerializeField] private EnemyScriptableObject enemyScriptableObject;

    [Header("MoveTarget")]
    [SerializeField] private TMP_InputField moveTargetHPInputField;
    [SerializeField] private TMP_InputField moveTargetTimeLimitInputField;
    [SerializeField] private TMP_InputField moveTargetSpeedInputField;
    [SerializeField] private MoveEnemyScriptableObject moveEnemyScriptableObject;

    [Header("RandomMoveTarget")]
    [SerializeField] private TMP_InputField randomMoveTargetHPInputField;
    [SerializeField] private TMP_InputField randomMoveTargetTimeLimitInputField;
    [SerializeField] private TMP_InputField randomMoveTargetSpeedInputField;
    [SerializeField] private RandomMoveEnemyScriptableObject randomMoveEnemyScriptableObject;

    [Header("TeleportTarget")]
    [SerializeField] private TMP_InputField teleportTargetHPInputField;
    [SerializeField] private TMP_InputField teleportTargetTimeLimitInputField;
    [SerializeField] private TMP_InputField teleportTargetChangePointTimeInputField;
    [SerializeField] private NeedRandomPointEnemyScriptableObject teleportEnemyScriptableObject;

    private void Start()
    {
        SetInputFieldData();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(3);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(1);
    }
    public void SetInputFieldData()
    {
        //staticTarget
        staticTargetHPInputField.text = enemyScriptableObject.Hp.ToString();
        staticTargetTimeLimitInputField.text = enemyScriptableObject.TimeLimit.ToString();

        //moveTarget
        moveTargetHPInputField.text = moveEnemyScriptableObject.Hp.ToString();
        moveTargetTimeLimitInputField.text = moveEnemyScriptableObject.TimeLimit.ToString();
        moveTargetSpeedInputField.text = moveEnemyScriptableObject.Speed.ToString();

        //randomMoveTarget
        randomMoveTargetHPInputField.text = randomMoveEnemyScriptableObject.Hp.ToString();
        randomMoveTargetTimeLimitInputField.text = randomMoveEnemyScriptableObject.TimeLimit.ToString();
        randomMoveTargetSpeedInputField.text = randomMoveEnemyScriptableObject.Speed.ToString();

        //teleportTarget
        teleportTargetHPInputField.text = teleportEnemyScriptableObject.Hp.ToString();
        teleportTargetTimeLimitInputField.text = teleportEnemyScriptableObject.TimeLimit.ToString();
        teleportTargetChangePointTimeInputField.text = teleportEnemyScriptableObject.SetRandomPointTime.ToString();
    }
    public void Save()
    {
        //staticTarget
        enemyScriptableObject.Hp = staticTargetHPInputField.text == "" ? 1 : int.Parse(staticTargetHPInputField.text);
        enemyScriptableObject.TimeLimit = staticTargetTimeLimitInputField.text == "" ? float.PositiveInfinity : float.Parse(staticTargetTimeLimitInputField.text);

        //moveTarget
        moveEnemyScriptableObject.Hp = moveTargetHPInputField.text == "" ? 1 : int.Parse(moveTargetHPInputField.text);
        moveEnemyScriptableObject.TimeLimit = moveTargetTimeLimitInputField.text == "" ? float.PositiveInfinity : float.Parse(moveTargetTimeLimitInputField.text);
        moveEnemyScriptableObject.Speed = moveTargetSpeedInputField.text == "" ? 10 : float.Parse(moveTargetSpeedInputField.text);

        //randomMoveTarget
        randomMoveEnemyScriptableObject.Hp = randomMoveTargetHPInputField.text == "" ? 1 : int.Parse(randomMoveTargetHPInputField.text);
        randomMoveEnemyScriptableObject.TimeLimit = randomMoveTargetTimeLimitInputField.text == "" ? float.PositiveInfinity : float.Parse(randomMoveTargetTimeLimitInputField.text);
        randomMoveEnemyScriptableObject.Speed = randomMoveTargetSpeedInputField.text == "" ? 1.5f : float.Parse(randomMoveTargetSpeedInputField.text);

        //teleportTarget
        teleportEnemyScriptableObject.Hp = teleportTargetHPInputField.text == "" ? 1 : int.Parse(teleportTargetHPInputField.text);
        teleportEnemyScriptableObject.TimeLimit = teleportTargetTimeLimitInputField.text == "" ? float.PositiveInfinity : float.Parse(teleportTargetTimeLimitInputField.text);
        teleportEnemyScriptableObject.SetRandomPointTime = teleportTargetChangePointTimeInputField.text == "" ? 1.5f : float.Parse(teleportTargetChangePointTimeInputField.text);
    }
}
