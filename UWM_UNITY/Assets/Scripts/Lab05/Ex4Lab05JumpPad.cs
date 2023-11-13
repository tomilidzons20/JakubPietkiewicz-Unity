using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4Lab05JumpPad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CharacterLab05 playerScript = other.gameObject.GetComponent<CharacterLab05>();
            CharacterController playerCh = other.gameObject.GetComponent<CharacterController>();
            Vector3 jumpForce = Vector3.up * playerScript.jumpHeight * 3;
            playerCh.Move(jumpForce);
        }
    }
}
