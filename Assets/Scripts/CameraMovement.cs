using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 position = new Vector3(-10, 5, -8);
    public float movement = 2f;

    void Start()
    {
        transform.position = position;
    }

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + 1 * movement * Time.deltaTime,
            position.y,
            position.z
        );
    }
}
