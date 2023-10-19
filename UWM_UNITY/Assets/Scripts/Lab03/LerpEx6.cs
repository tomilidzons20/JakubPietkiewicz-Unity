using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpEx6 : MonoBehaviour
{
    public float minimum = -1.0f;
    public float maximum = 1.0f;
    float startX;

    static float t = 0.0f;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(startX + minimum, startX + maximum, t), transform.position.y, transform.position.z);

        t += 0.5f * Time.deltaTime;

        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
}
