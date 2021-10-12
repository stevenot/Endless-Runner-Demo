using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    private string groundTag = "Ground";
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != groundTag)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Score>().UpdateHighScore();
        }
    }
}
