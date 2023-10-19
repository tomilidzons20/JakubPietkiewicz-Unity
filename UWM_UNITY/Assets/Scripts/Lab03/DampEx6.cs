using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DampEx6 : MonoBehaviour
{
    public Vector3 target = new Vector3(0, 3, 5);
    public float smoothTime = 0.3f;
    public float yVelocity = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.x, target.x, ref yVelocity, smoothTime);
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}
