using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Runtime.InteropServices;

using Unity.VisualScripting;

public class MenuControllerM : MonoBehaviour
{
    public SettingsCOntrollerM stM;
    [SerializeField] private GameObject GameController2M;
    
    
    void Start()
    {
        
        
    }
    public void SettingsButtonM() 
    {
        SceneManager.LoadScene("Test2M");
    }
    
    public void ExitButtonM()
    {
        Application.Quit();
    }
    public void StartButtonM()
    {
        
    }
    void Update()
    {
        
    }
    private void OnApplicationQuit()
    {
        
    }
}
