using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameChecker : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] figureSpawn;

    private int time = 10;
    private float timePassed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 1.0f && time >= 0)
        {
            time += 1;
            timePassed = 0f;

            int randFigure = Random.Range(0, figureSpawn.Length);
            int randSpawnPoint = Random.Range(0, 2);
            Instantiate(figureSpawn[randFigure], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
