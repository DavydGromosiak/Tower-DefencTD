using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelConttrollerD : MonoBehaviour
{
    public static LevelConttrollerD instance = null;
    int sceneIndex; 
    int levelComlete;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComlete = PlayerPrefs.GetInt("LevelComlete");
    }

    public void isEndGame()
    {
        if (sceneIndex == 4)
        {
            Invoke("LoadMainMenu", 1f);
        }
        else
        {
            if (levelComlete < sceneIndex)
                PlayerPrefs.SetInt("LevelComlete", sceneIndex);
            Invoke("NextLevel", 1f);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    void LoadMainMenu()
    {
        SceneManager.LoadScene(2);
    }
}
