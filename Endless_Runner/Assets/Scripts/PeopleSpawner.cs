using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    Rigidbody2D playerObject; 

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;
    int chance = 1;

    public float spawntime = 3.0f;

    void start()
    {
        timeToNextSpawn = spawntime;
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            if (chance == 1)
            {
               Instantiate(objectToSpawn,transform.position, Quaternion.identity);
            }

            timeSinceLastSpawn = 0.0f;
            timeToNextSpawn = spawntime;
            chance = Random.Range(0,2);
        }
    }
}
