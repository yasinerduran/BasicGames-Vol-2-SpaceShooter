using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Rigidbody physics;
    public float BulletVelocity;
    void Start()
    {
        physics.GetComponent<Rigidbody>();
        physics.velocity = transform.forward*BulletVelocity;
    }

}
