using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    public AudioSource scoreUpSound;

    public SpriteRenderer pipe1, pipe2;
    private Color basePipeColor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().score++;
            scoreUpSound.Play();

            StartCoroutine(ScoreUpAnim());
        }
    }

    private IEnumerator ScoreUpAnim()
    {
        basePipeColor = pipe1.color;
        pipe1.color = Color.white;
        pipe2.color = Color.white;

        yield return new WaitForSeconds(0.3f);

        pipe1.color = basePipeColor;
        pipe2.color = basePipeColor;
    }
}