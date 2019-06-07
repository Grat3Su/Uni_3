using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject[] ObstaclePattern;

    private float timeBtweenSpawn;
    public float StartTimeBtweenSpawn;

    public float decreaseTime;
    public float minTime = 0.65f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rand;
        if(timeBtweenSpawn<=0)
        {
            rand = Random.Range(0, ObstaclePattern.Length);
            Instantiate(ObstaclePattern[rand], transform.position, Quaternion.identity);//장애물 0 : 파랑. 1 : 빨강
            timeBtweenSpawn = StartTimeBtweenSpawn;
            if(StartTimeBtweenSpawn>minTime)
            {
                StartTimeBtweenSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBtweenSpawn -= Time.deltaTime;
        }
    }
}
