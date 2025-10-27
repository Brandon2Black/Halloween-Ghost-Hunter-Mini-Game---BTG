using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] ghostPrefabs;


    public int ghostIndex;
    public int spawnIndex;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    

    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    public GameObject[] spawnPoses;
   
    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("SpawnRandomGhost", startDelay, Random.Range(spawnInterval, 5));
    }
 

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomGhost()
    {


          Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
           int ghostIndex = Random.Range(0, ghostPrefabs.Length);
           int spawnIndex = Random.Range(0, spawnPoses.Length);
      Instantiate(ghostPrefabs[ghostIndex], spawnPoses[spawnIndex].transform.position, ghostPrefabs[ghostIndex].transform.rotation);
    }
}

