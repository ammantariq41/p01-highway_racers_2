using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject FuelMenuUI;
    public static bool GameisNotPaused = true;
    public TextMeshProUGUI timerText;
    public  static  int fuel;
    public TextMeshProUGUI FuelText;
    public  static  int score;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        fuel=2;
        score=0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.RightArrow) && GameisNotPaused)
        {
            score=score+1;
            if(score%100==0 && score!=0 && GameisNotPaused)
        {
         fuel=fuel-1;
         if (fuel==0)
         {
            Time.timeScale = 0;
            GameisNotPaused = false;
            FuelMenuUI.SetActive(true);
         }
        }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow)&& GameisNotPaused)
        {
            score=score+1;
            if(score%100==0 && score!=0 && GameisNotPaused)
        {
         fuel=fuel-1;
         if (fuel==0)
         {
            Time.timeScale = 0;
            GameisNotPaused = false;
            FuelMenuUI.SetActive(true);
         }
        }
        }
         if (Input.GetKey(KeyCode.UpArrow)&& GameisNotPaused)
        {
            score=score+1;
            if(score%100==0 && score!=0 && GameisNotPaused)
        {
         fuel=fuel-1;
         if (fuel==0)
         {
            Time.timeScale = 0;
            GameisNotPaused = false;
            FuelMenuUI.SetActive(true);
         }
        }
        }
        if (Input.GetKey(KeyCode.DownArrow)&& GameisNotPaused)
        {
            score=score+1;
            if(score%100==0 && score!=0 && GameisNotPaused)
        {
         fuel=fuel-1;
         if (fuel==0)
         {
            Time.timeScale = 0;
            GameisNotPaused = false;
            FuelMenuUI.SetActive(true);
         }
        }
        }
        
        string seconds = (score).ToString();
        timerText.text="Score: " + seconds;
        string fuelconvert=(fuel).ToString();
        FuelText.text="Fuel: "+fuel;
    }
}