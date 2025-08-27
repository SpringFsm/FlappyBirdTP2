using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class PipeMovement : MonoBehaviour
{
    private static float speed = 2.5f;

    private GameManager gm;

    private float timer;
    public float rankUpTime;
    public float speedInc;

    public Transform topPipe;

    private float minRange = -0.5f;
    private float maxRange = 2.5f;
    private void Start()
    {
        float moreYRandomness = Random.Range(-0.5f, 2);
        topPipe.position += new Vector3(0, moreYRandomness, 0);
        gm = FindObjectOfType<GameManager>();
        timer = rankUpTime;
    }

    private void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        
        // pipes will go faster as time goes by
        if (timer <= 0)
        {
            timer = rankUpTime;
            speed += speedInc;
            //Top pipe will go lower as time goes by, closing the gap
            minRange -= 0.1f;
            maxRange -= 0.1f;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
