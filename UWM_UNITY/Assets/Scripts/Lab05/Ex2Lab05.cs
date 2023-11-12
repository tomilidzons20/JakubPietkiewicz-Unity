using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2Lab05 : MonoBehaviour
{
    private bool isOpen;
    private Vector3 startingPosition;
    private Vector3 endingPosition;
    public float speed = 2f;
    public GameObject door;
    public bool openToLeft = true;

    private void Start()
    {
        startingPosition = door.transform.position;
        endingPosition = startingPosition;
        Vector3 moveDistance = Vector3.left * 3;
        if (openToLeft)
            endingPosition += moveDistance;
        else
            endingPosition -= moveDistance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOpen)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, endingPosition, speed * Time.fixedDeltaTime);
        }
        else
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, startingPosition, speed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("ENTER");
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("EXIT");
            isOpen = false;
        }
    }
}
