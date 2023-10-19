using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEx2 : MonoBehaviour
{
    public float speed;
    public Vector3 startingPosition;
    
    void Start()
    {
        startingPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if(transform.position.x >= startingPosition.x + 10.0f) {
            speed *= -1.0f;
        }
        if(transform.position.x < startingPosition.x) {
            speed *= -1.0f;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
