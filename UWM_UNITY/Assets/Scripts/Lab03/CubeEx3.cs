using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEx3 : MonoBehaviour
{
    public float speed;
    public Vector3 endPosition;

    void Start()
    {
        endPosition = transform.position + transform.forward * 10;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, endPosition) < 0.001f)
        {
            transform.Rotate(0, 90, 0, Space.Self);
            endPosition = transform.position + transform.forward * 10;
        }
    }
}
