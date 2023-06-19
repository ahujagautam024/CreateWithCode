using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Variables
    public GameObject[] animalGameObjects;
    [SerializeField] KeyCode spawnAnimalsKeyCode;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    #endregion

    #region UntiyMethods
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    #endregion


    #region CustomMethods
    private void SpawnRandomAnimal()
    {
        // Randomly generating the Index
        int animalIndex = Random.Range(0, animalGameObjects.Length);

        // Randomly generating the X position of the Animal Spawn
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalGameObjects[animalIndex], spawnPos, animalGameObjects[animalIndex].transform.rotation);
    }
    #endregion
}
