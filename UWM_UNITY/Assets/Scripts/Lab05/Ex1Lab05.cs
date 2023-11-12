using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1Lab05 : MonoBehaviour
{
    public float speed = 2f;
    private bool isRunning = false;
    public Transform startPoint;
    public Transform endPoint;

    void FixedUpdate()
    {
        if (isRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.fixedDeltaTime);
        } 
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.position, speed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("ENTER");
            other.gameObject.transform.parent = transform;
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("EXIT");
            other.gameObject.transform.parent = null;
            isRunning = false;
        }
    }
}
