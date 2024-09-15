using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;

    private float spawnRangeX = 20;
    private float zSpawnPos = 20;

    //private float startDelay = 2;
    //private float spawnInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomAnimal", startDelay. spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            //Randomly generate animal index and spawn position
            SpawnRandomAnimals();
            
        }
    }

    void SpawnRandomAnimals(){
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, zSpawnPos);
        int animalIndox = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndox], spawnPos, animalPrefabs[animalIndox].transform.rotation);

    }
}
