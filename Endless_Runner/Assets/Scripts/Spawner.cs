using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject [] objectsToSpawn;
    Rigidbody2D playerObject;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float distance = 20;

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
            int selection = Random.Range(0, objectsToSpawn.Length);

            Instantiate(objectsToSpawn[selection],transform.position, Quaternion.identity);


            timeSinceLastSpawn = 0.0f;
            timeToNextSpawn = spawntime;
            playerObject.velocity = new Vector2 (distance,0);
        }
    }
}
