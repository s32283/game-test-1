using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_collizion : MonoBehaviour
{
    public bool isGrounded;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
