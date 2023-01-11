using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] EnvironmentScriptableObject environmentScriptableObject;
    private void Start()
    {
        environmentScriptableObject.Configured = false;
    }
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
    public void OnEnableDisableFullScreenButtonPressed()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
    public void OnExitButtonPressed()
    {
        Application.Quit();
    }
}
