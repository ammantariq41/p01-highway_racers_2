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
    void LateUpdate()
    {
        score = score + 0.3f;

      
        string seconds = (Mathf.Floor(score)).ToString();
        timerText.text="Score: " + seconds;
    }
}
