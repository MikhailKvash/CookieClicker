using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isLoading;
    
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedCookies"))
        {
            isLoading = true;
            SceneManager.LoadScene(1);
        }
    }
}
