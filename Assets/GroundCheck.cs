using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] PlayerController pc;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        pc.isGrounded = true;
    }
}
