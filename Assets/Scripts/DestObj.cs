using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


    public class DestObj : MonoBehaviour
    {
    public ProgressBar pb;

        public static float col_hit = 0;
        public AudioSource audioSource;
        public Transform dust;

        // Start is called before the first frame update
        void Start()
        {
            
            col_hit = 0;
        pb.BarValue = 100;
            audioSource = GetComponent<AudioSource>();
            dust.GetComponent<ParticleSystem>().enableEmission = false;
        }

        // Update is called once per frame

        IEnumerator OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "tri")
            {
                other.gameObject.SetActive(false);
                Debug.Log("Hit Obstacle");
                audioSource.Play();
                dust.GetComponent<ParticleSystem>().enableEmission = true;
                StartCoroutine(stopSparkle1());

                col_hit = col_hit + 1;
                if (col_hit == 4)
                {
                    Destroy(gameObject);
                    SceneManager.LoadScene(3);
                }
            }

            pb.BarValue = (1 - (col_hit / 4)) * 100;
            

            yield return new WaitForSeconds(2);
            other.gameObject.SetActive(true);
        }

        IEnumerator stopSparkle1()
        {
            Debug.Log("Dust");
            yield return new WaitForSeconds(.4f);
            dust.GetComponent<ParticleSystem>().enableEmission = false;
        }

    }

