using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject PanelPause;
    [SerializeField] private GameObject PanelUI;
    public void Pause()
    {
        PanelPause.SetActive(true);
        PanelUI.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        PanelPause.SetActive(false);
        PanelUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void Retry()
    {
        
    }
    public void Menu()
    {
        
    }
}
