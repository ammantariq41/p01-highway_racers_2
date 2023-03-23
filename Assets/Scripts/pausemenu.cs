using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;

    }

   private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameisPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu.....");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game....");
        SceneManager.LoadScene(0);
    }
}
