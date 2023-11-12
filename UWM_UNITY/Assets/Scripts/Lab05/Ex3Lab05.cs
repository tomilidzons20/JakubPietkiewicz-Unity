using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3Lab05 : MonoBehaviour
{
    public float speed = 2f;
    public List<Vector3> points = new List<Vector3>();
    private bool movingAscending = true;
    private int i = 0;
    private List<Vector3> movingPoints = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        movingPoints.Add(transform.position);
        movingPoints.AddRange(points);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, movingPoints[i]) < 0.001f)
        {
            if (i == 0)
                movingAscending = true;
            if (i == movingPoints.Count - 1)
                movingAscending = false;

            if (movingAscending)
                i++;
            else
                i--;
        }
        transform.position = Vector3.MoveTowards(transform.position, movingPoints[i], speed * Time.fixedDeltaTime);
    }
}
