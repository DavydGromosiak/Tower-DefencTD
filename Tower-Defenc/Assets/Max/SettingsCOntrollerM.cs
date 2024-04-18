using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingsCOntrollerM : MonoBehaviour
{
    
    [SerializeField] private GameObject GameControllerM;
    [SerializeField] public Slider sliderM;
    [SerializeField] private GameObject PanelS;

    private AudioSource audioSM;
    private bool settingsActive = false;


    void Start()
    {
        audioSM = GameControllerM.GetComponent<AudioSource>();
        sliderM.value = audioSM.volume;
        
    }

    public void SettingsActive()
    {
        settingsActive = !settingsActive;
        PanelS.SetActive(settingsActive);
    }

    public void ExitButtonSM()
    {
        SceneManager.LoadScene("TestM");
    }
    
    void Update()
    {
        
        audioSM.volume = sliderM.value;
    }
}
