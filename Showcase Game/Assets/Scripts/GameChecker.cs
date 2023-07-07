using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameChecker : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] figureSpawn;

    private float timePassed = 0f;

    //private int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    ObstacleMovement obstacleMovement;
    [SerializeField] GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 2.0f)
        {
            timePassed = 0f;

            int randFigure = Random.Range(0, figureSpawn.Length);
            int randSpawnPoint = Random.Range(0, 2);
            Instantiate(figureSpawn[randFigure], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
