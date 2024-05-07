using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void Level01()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void Level02()
    {
        SceneManager.LoadScene("Level 2");
    }
    
    public void Level03()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void BackMenu()
    {
        SceneManager.LoadScene("_MainMenu");
    }
}
