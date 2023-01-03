using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlaySceneSettingsManager : MonoBehaviour
{
    //--INPUT--//
    [SerializeField] Slider cameraViewSlider;
    [SerializeField] Toggle haveTimeLimitToggle;
    [SerializeField] GameObject inputFieldGameObject;
    [SerializeField] TMP_InputField minTMP;
    [SerializeField] TMP_InputField segTMP;

    [SerializeField] TMP_InputField bulletSpeedInputField;

    [SerializeField] Slider staticTargetSizeSlider;
    [SerializeField] Slider moveTargetSizeSlider;
    [SerializeField] Slider randomMoveTargetSizeSlider;
    [SerializeField] Slider teleportTargetSizeSlider;

    //--OUTPUT--//
    [SerializeField] EnvironmentScriptableObject environmentData;
    [SerializeField] BulletScriptableObject bulletScriptableObject;

    [SerializeField] EnemyScriptableObject staticTargetData;
    [SerializeField] MoveEnemyScriptableObject moveTargetData;
    [SerializeField] NeedRandomPointEnemyScriptableObject randomMoveTargetData;
    [SerializeField] NeedRandomPointEnemyScriptableObject teleportTargetData;

    private void Start()
    {
        SetEnvironmentData();
    }
    void SetEnvironmentData()
    {
        //camera view
        cameraViewSlider.value = environmentData.CameraView;
        
        //Time limit
        haveTimeLimitToggle.isOn = environmentData.HaveTimeLimit;
        if (haveTimeLimitToggle.isOn)
        {
            minTMP.text = environmentData.Min.ToString();
            segTMP.text = environmentData.Seg.ToString();
        }
        //bullet speed
        bulletSpeedInputField.text = bulletScriptableObject.Speed.ToString();

        //targets size
        staticTargetSizeSlider.value = staticTargetData.Size;
        moveTargetSizeSlider.value = moveTargetData.Size;
        randomMoveTargetSizeSlider.value = randomMoveTargetData.Size;
        teleportTargetSizeSlider.value = teleportTargetData.Size;
    }
    public void CameraViewSlider()
    {
        Camera.main.orthographicSize = cameraViewSlider.value;
    }

    public void HaveTimeLimitToggle()
    {
        inputFieldGameObject.SetActive(haveTimeLimitToggle.isOn);
    }
    public void MinInputField()
    {
        
    }
    public void SegInputField()
    {
        if (segTMP.text != "") segTMP.text = Mathf.Clamp(int.Parse(segTMP.text), 0, 59) + "";
    }
    public void BulletSpeedInputField()
    {
        bulletScriptableObject.Speed = bulletSpeedInputField.text == "" ? 70 : float.Parse(bulletSpeedInputField.text);
    }

    public void NextScene()
    {
        Save();
        SceneManager.LoadScene(2);
    }
    void Save()
    {
        //save camera view
        environmentData.CameraView = cameraViewSlider.value;

        //save time limit
        environmentData.HaveTimeLimit = haveTimeLimitToggle.isOn;
        if (haveTimeLimitToggle.isOn)
        {
            if (minTMP.text != "") environmentData.Min = int.Parse(minTMP.text);
            else environmentData.Min = 0;

            if (segTMP.text != "") environmentData.Seg = int.Parse(segTMP.text);
            else environmentData.Seg = 0;
        }

        //save target size
        staticTargetData.Size = staticTargetSizeSlider.value;
        moveTargetData.Size = moveTargetSizeSlider.value;
        randomMoveTargetData.Size = randomMoveTargetSizeSlider.value;
        teleportTargetData.Size = teleportTargetSizeSlider.value;
    }
}
