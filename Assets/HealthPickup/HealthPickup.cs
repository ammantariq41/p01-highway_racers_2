using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
   
    
{
    
    public static float tracksPassed;
    public AudioSource healthSound;
   

    // Start is cthe first frame update
    void Start()
    {


        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (TerrainManager.terrainsPassed % 1 == 0 && TerrainManager.terrainsPassed != 0)
        {
            GetComponent<CapsuleCollider>().enabled = true;
            GetComponent<MeshRenderer>().enabled = true;

          



        }
        if (TerrainManager.terrainsPassed % 10 == 2)
        {
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;





        }


    }

   void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            healthSound.Play();
            if (DestObj.col_hit != 0)

               
            {
                DestObj.col_hit -= 1;
                Debug.Log("Inside trigger col hit");
                GetComponent<CapsuleCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                
                
            }


            



        }
    }
}
