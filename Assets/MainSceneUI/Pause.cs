using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool IsPaused { get; private set; }
    [SerializeField] GameObject pausePanel;
    private void Awake()
    {
        IsPaused = false;
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMethod();
        }
    }
    public void PauseMethod()
    {
        Time.timeScale = IsPaused ? 1 : 0;
        IsPaused = !IsPaused;
        pausePanel.SetActive(!pausePanel.activeSelf);
    }
}
