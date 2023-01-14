using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{

    public GameObject[] terrainPrefabs;
    public float zSpawn = 0;
    public float terrainLength = 200;
    public int numberOfTerrains = 3;
    private List<GameObject> activeTerrains = new List<GameObject>();


    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < numberOfTerrains; i++)
        {
            SpawnTerrain(Random.Range(0, terrainPrefabs.Length));

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (playerTransform.position.z - 200 > zSpawn - (numberOfTerrains * terrainLength))
        {
            SpawnTerrain(Random.Range(0, terrainPrefabs.Length));
            OffTerrain();
        }

    }

    public void SpawnTerrain(int tileIndex)
    {
        GameObject go = Instantiate(terrainPrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTerrains.Add(go);
        Debug.Log(tileIndex);
        //activeTerrains.SetActive(true);
        zSpawn += terrainLength;
    }

    private void OffTerrain()
    {
        Destroy(activeTerrains[0]);
        activeTerrains.RemoveAt(0);
        //activeTerrains[0].SetActive(false);

        // instead of deleting, set it as inactive
        // activeTiles[0] set inactive, reposition, and set active again. instead of deleting and creating which is resource heavy
    }
}
