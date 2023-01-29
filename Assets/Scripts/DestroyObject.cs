using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float col_hit = 0;
    public AudioSource audioSource;
    public Transform dust;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dust.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "tri")
        {
            Debug.Log("Hit Obstacle");
            audioSource.Play();
            dust.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine (stopSparkle1());

            col_hit = col_hit + 1;
            // if (col_hit == 4)
            // {
            //     Destroy(gameObject);
            //     SceneManager.LoadScene(2);
            // }
        }
        timerText.text = "Hits Left" + col_hit.ToString() + "/4";
    }

    IEnumerator stopSparkle1()
    {
        Debug.Log("Dust");
        yield return new WaitForSeconds (.4f);
        dust.GetComponent<ParticleSystem>().enableEmission = false;
    }

}
