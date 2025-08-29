using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public float timeToSpawn;
    private float timer;
    private int count;
    public int rankupCount; // rank up : difficulty up
    
    public GameObject pipe;

    private GameManager gm;

    private void Start()
    {
        timer = 0;
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(gm.gameOver){ return; }
        if (timer <= 0)
        {
            if (count == rankupCount) // every 5 spawns, time to spawn is shorter
            {
                timeToSpawn -= 0.1f;
                if (timeToSpawn <= 0.5f) // clamp at 0.5s
                {
                    timeToSpawn = 0.5f;
                }
                count = 0;
            }
            SpawnPipe();
            timer = timeToSpawn;
            count++;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    
    private void SpawnPipe()
    {
        float randomYOffset = Random.Range(-2f, 0.7f);
        Vector2 spawnPos = new Vector2(transform.position.x, transform.position.y + randomYOffset);
        
        Instantiate(pipe, spawnPos, Quaternion.identity);
    }
}
