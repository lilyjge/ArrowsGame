using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    private GameObject spawnedArr;

    public Transform[] spawnPoints;

    public float elapsedTime = 0.0f;

    void Start()
    {
        

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        float secondsBetweenSpawn = Random.Range(1, 5);

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;

            SpawnArr();
        }
    }



    void SpawnArr()
    {
        

        int rand = Random.Range(0, 4);
        spawnedArr = Instantiate(enemyPrefabs[rand]);

        switch(rand)
        {
            case 0:
                spawnedArr.transform.position = new Vector3(Random.Range(-8, 8), spawnPoints[rand].position.y, 0f);
                spawnedArr.GetComponent<Arrow>().speed = Random.Range(4, 10);
                break;
            case 1:
                spawnedArr.transform.position = new Vector3(spawnPoints[rand].position.x, Random.Range(-4, 4), 0f);
                spawnedArr.GetComponent<Arrow>().speed = Random.Range(4, 10);
                break;
            case 2:
                spawnedArr.transform.position = new Vector3(spawnPoints[rand].position.x, Random.Range(-4, 4), 0f);
                spawnedArr.GetComponent<Arrow>().speed = Random.Range(4, 10);
                break;
            case 3:
                spawnedArr.transform.position = new Vector3(Random.Range(-8, 8), spawnPoints[rand].position.y, 0f);
                spawnedArr.GetComponent<Arrow>().speed = Random.Range(4, 10);
                break;
        }
        spawnedArr.GetComponent<Arrow>().randHolder = rand;
    }

}
