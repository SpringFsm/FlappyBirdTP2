using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BirdRotationAnimation : MonoBehaviour
{
    private Rigidbody2D rb;

    public float rotationSpeed;

    private GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<GameManager>();
    }

    void FixedUpdate()
    {
        if (gm.gameOver)
        {
            transform.rotation = Quaternion.identity;
            return;
        }

        if (rb.velocity.y >= 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 33), rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -90), rotationSpeed * Time.deltaTime);
        }
    }
}
