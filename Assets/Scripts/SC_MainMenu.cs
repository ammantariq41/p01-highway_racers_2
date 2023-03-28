using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MainMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    // public GameObject pauseMenuUI;
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        // MainMenuButton();
    }

    public void BuyFuel()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        if(GameisPaused)
        {
                Resume();
        } else
        {
                Pause();
        }
        Debug.Log("Fuel Bought");

        if(GameisPaused)
        {
                Resume();
        }
    }
       public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
        public void Resume()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;

    }

    public void Pause()
    {
        MainMenu.SetActive(true);
        Time.timeScale = 0;
        GameisPaused = true;
    }

 
}
