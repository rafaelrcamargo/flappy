using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 100f;
    public float jumpHeight = 250f;
    public Camera cam;

    private bool _jump = false;

    // * Update Methods
    private void CheckPlayerPosition()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(rb.position);

        if (viewPos.x < -0.1 || viewPos.y < -0.1 || viewPos.y > 1.1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void CheckJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jump = true;
        }
    }

    void Update()
    {
        CheckJump();
        CheckPlayerPosition();
    }

    // * Fixed Update Methods
    private void FlyAndJump()
    {
        if (_jump)
        {
            rb.AddForce(movementSpeed * Time.deltaTime, jumpHeight, 0);
            _jump = false;
        }
        else
        {
            rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }
    }

    void FixedUpdate()
    {
        FlyAndJump();
    }
}
