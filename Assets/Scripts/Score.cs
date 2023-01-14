using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float score;
     Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
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
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     score=score+1;
        // }
      
        string seconds = (score).ToString();
        timerText.text="Score: " + seconds;
    }
}
