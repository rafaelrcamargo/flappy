using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 100f;
    public float jumpHeight = 250f;
    public Camera cam;

    void Update()
    {
        rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, jumpHeight, 0);
        }

        Vector3 viewPos = cam.WorldToViewportPoint(rb.position);
        if (
            viewPos.x > -0.1
            && viewPos.x < 1.1
            && viewPos.y > -0.1
            && viewPos.y < 1.1
            && viewPos.z > -0.1
        )
        {
            Debug.Log("...");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
