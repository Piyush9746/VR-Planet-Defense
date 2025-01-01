using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Destroy the object the bullet collided with
        Destroy(collision.gameObject);

        // Optionally destroy the bullet itself after collision
        Destroy(gameObject);
    }
}
