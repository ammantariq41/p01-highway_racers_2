using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryEndMenu : MonoBehaviour
{
	public void RetryGame()
	{
		SceneManager.LoadScene(1); //replays the game scene from start
	}
}
