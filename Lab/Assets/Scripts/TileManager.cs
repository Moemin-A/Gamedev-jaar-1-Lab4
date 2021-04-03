using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private GameObject platforms;
    private float spawnZ = 0.0f;
    private float tileLenght = 100f;
    private int amnTilesOnScreen = 3;
    private int maxTilesOnScreen = 8;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        platforms = GameObject.FindWithTag("platforms"); // Finds gameobject with tag 'go'.
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (amnTilesOnScreen > maxTilesOnScreen)
        {
            Destroy(GameObject.FindWithTag("platforms"));
        }
        else if (playerTransform.position.z > (spawnZ - amnTilesOnScreen * tileLenght))
        {
            SpawnTile ();
        }
     

    }


    public void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLenght;
     
    }

}
