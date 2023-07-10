using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameChecker : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] figureSpawn;

    private float timePassed = 0f;
    private float waitTime = 2.0f;
    private int timesSpawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
        timesSpawned = 0;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > waitTime)
        {
            timePassed = 0f;
            timesSpawned++;

            int randFigure = Random.Range(0, figureSpawn.Length);
            int randSpawnPoint = Random.Range(0, 2);
            Instantiate(figureSpawn[randFigure], spawnPoints[randSpawnPoint].position, transform.rotation);
        }

        else if (timesSpawned == 10)
        {
            waitTime = 1.7f;
        }
        else if (timesSpawned == 25)
        {
            waitTime = 1.5f;
        }
        else if (timesSpawned == 50)
        {
            waitTime = 1.2f;
        }
    }
}
