using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float col_hit = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "tri")
        {
            col_hit = col_hit + 1;
            if (col_hit == 4)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
        timerText.text = "Hits: " + col_hit.ToString() + "/4";

    }

}
