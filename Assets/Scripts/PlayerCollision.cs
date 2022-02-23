using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float vel = 0f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.body as Rigidbody)
        {
            Debug.Log(collision.collider.name);
            collision.collider.attachedRigidbody.useGravity = true;
        }
    }
}
