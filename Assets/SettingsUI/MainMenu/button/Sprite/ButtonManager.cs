using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
}
