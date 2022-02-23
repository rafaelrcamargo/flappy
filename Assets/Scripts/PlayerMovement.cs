using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 100f;
    public float jumpHeight = 250f;

    void FixedUpdate()
    {
        rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, jumpHeight, 0);
        }
    }
}
