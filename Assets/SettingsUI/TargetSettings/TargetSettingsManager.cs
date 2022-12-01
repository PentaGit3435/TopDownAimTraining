using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetSettingsManager : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(3);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(1);
    }
}
