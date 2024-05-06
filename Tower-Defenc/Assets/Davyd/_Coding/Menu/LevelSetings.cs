using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelSetings : MonoBehaviour
{
    public Button Level2B;
    public Button Level3B;
    int levelComplete;
    
    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("levelComplete");
        Level2B.interactable = false;
        Level3B.interactable = false;

        switch (levelComplete)
        {
            case 1:
                Level2B.interactable = true;
                break;
            case 2:
                Level2B.interactable = true;
                Level3B.interactable = true;
                break;
            
        }
    }


    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
  
    public void Reset()
    {
        Level2B.interactable = false;
        Level3B.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
