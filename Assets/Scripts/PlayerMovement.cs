using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8;
    public float horizontalSpeed = 5;
    public float jumpForce = 15;
    public LayerMask groundLayers;
    public GameObject michelle;

    private Rigidbody rb;
    private Collider col;
    private Animator anim;

    bool IsGrounded()
    {
        bool grounded = false;

        grounded = Physics.Raycast(col.bounds.center, Vector3.down, col.bounds.extents.y, groundLayers);
        if (grounded == true)
        {
            anim.SetBool("IsJumping", false);
        }
        return grounded;
    }
    private void Move()
    {
        Vector3 forwardMove;
        forwardMove = transform.forward * Time.deltaTime * speed;
        rb.MovePosition(rb.position + forwardMove);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector3.left * Time.fixedDeltaTime * horizontalSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector3.right * Time.fixedDeltaTime * horizontalSpeed);
        }
        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Physics.gravity = new Vector3(0, -35.0f, 0);
        }
    }

    private void Start()
    {
        michelle = GameObject.Find("Ch03_nonPBR@Run");
        anim = michelle.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
}
