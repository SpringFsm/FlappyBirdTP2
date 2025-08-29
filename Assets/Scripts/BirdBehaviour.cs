using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    
    private GameManager gameManager;

    public AudioSource flapSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            flapSound.Play();

        }

        if (gameManager.gameOver)
        {
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponentInChildren<Animator>().SetBool("GameOver", true);
        }
    }
}