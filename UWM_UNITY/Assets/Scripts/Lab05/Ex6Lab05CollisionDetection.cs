using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6Lab05CollisionDetection : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Doszlo do kolizji z przeszkoda");
        }
    }
}
