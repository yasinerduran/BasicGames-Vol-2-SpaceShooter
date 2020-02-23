using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public Rigidbody physics;
    public float BulletVelocity;
    void Start()
    {
        physics.GetComponent<Rigidbody>();
        physics.velocity = transform.forward * BulletVelocity * (-1 * Random.Range(1, 3));
    }
}
