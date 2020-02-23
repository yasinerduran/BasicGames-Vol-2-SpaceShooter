using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRoater : MonoBehaviour
{
    // Start is called before the first frame update
    float sizeOfCube;

    float velocity;
    float sizeLimitter;

    float speedOfRotation = 0;
    bool flag = true;

    public float rotateDir;

    public float sizeDecreaseLimit;
    public bool isSizeTransform;
    void Start()
    {
        velocity = Random.Range(0.002f, 0.0045f);
        sizeLimitter = this.gameObject.transform.localScale.x;
        rotateDir = Random.Range(-1, 1);
        if (rotateDir < 0)
        {
            rotateDir = -1;
        }
        else
        {
            rotateDir = 1;
        }
        speedOfRotation = (Random.Range(5, 15));
        if (sizeDecreaseLimit == 0f && isSizeTransform)
        {
            sizeDecreaseLimit = 1.2f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(new Vector3(speedOfRotation, speedOfRotation, speedOfRotation) * (rotateDir * Time.deltaTime));
        if ((sizeLimitter / sizeDecreaseLimit) > transform.localScale.x)
        {
            flag = false;
        }
        if (transform.localScale.x > sizeLimitter)
        {
            flag = true;
        }

        if (flag)
        {
            transform.localScale = new Vector3(transform.localScale.x - velocity, transform.localScale.z - velocity, transform.localScale.y - velocity);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x + velocity, transform.localScale.z + velocity, transform.localScale.y + velocity);
        }


    }
}
