using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI timerText;
      float fuel;
    public TextMeshProUGUI FuelText;
    float score;
     Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        fuel=100;
        score=0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.RightArrow))
        {
            score=score+1;
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            score=score+1;
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
            score=score+1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            score=score+1;
        }
        if(score%100==0 && score!=0)
        {
         fuel=fuel-1;
         if (fuel==0)
         {
            SceneManager.LoadScene(2);
         }
        }
        string seconds = (score).ToString();
        timerText.text="Distance: " + seconds;
        string fuelconvert=(fuel).ToString();
        FuelText.text="Fuel: "+fuel;
    }
}