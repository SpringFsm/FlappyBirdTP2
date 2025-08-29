using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        if (transform.position.x < -16)
        {
            transform.position = transform.position + new Vector3(39, 0, 0);
        }

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
