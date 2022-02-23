using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerBody;

    public Vector3 offset;

    void Update()
    {
        transform.position = playerBody.position + offset;
    }
}
