using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SC_MainMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    // public GameObject pauseMenuUI;
    public GameObject MainMenu;
    public TextMeshProUGUI buying;
    // public GameObject FuelMenuUI;

    // Start is called before the first frame update
 

    public void BuyFuel()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        if(PlayerMovement.numberOfCoins>10)
        {
                PlayerMovement.numberOfCoins=PlayerMovement.numberOfCoins-10;
                Score.fuel=100;
                buying.text="You bought fuel using 10 coins";
                Score.GameisNotPaused=true;
                Time.timeScale = 1f;
                MainMenu.SetActive(false);
                return;
        } else
        {
                buying.text="Ending the game. You dont have 10 coins";
                Application.Quit();
        }
    }
       public void QuitButton()
    {
        // Quit Game
        buying.text="Quit game";
        Application.Quit();
    }
   

 
}
