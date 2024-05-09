using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void Level01()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    
    public void Level02()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }
    
    public void Level03()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }
    
    public void BackMenu()
    {
        SceneManager.LoadScene("_MainMenu");
        Time.timeScale = 1f;
    }
}
