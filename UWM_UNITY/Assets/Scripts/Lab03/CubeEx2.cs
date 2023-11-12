using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEx2 : MonoBehaviour
{
    public float speed;
    public Vector3 endPosition;
    public Vector3 startPosition;
    Vector3 movePoint;
    
    void Start()
    {
        endPosition = transform.position;
        endPosition.x += 10;
        startPosition = transform.position;
        movePoint = endPosition;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint) < 0.001f)
        {
            if(movePoint == endPosition)
            {
                movePoint = startPosition;
            }
            else
            {
                movePoint = endPosition;
            }
        }
    }
}
