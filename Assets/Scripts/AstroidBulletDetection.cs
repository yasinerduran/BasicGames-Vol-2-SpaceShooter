using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBulletDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject BulletHitEffect;
    public GameObject ExplodeEffect;
    int liveCounter = 5;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Instantiate(BulletHitEffect, transform.position, transform.rotation);
            liveCounter -= 1;
            if (liveCounter == 0)
            {
                Destroy(gameObject);
                Instantiate(ExplodeEffect, transform.position, transform.rotation);
            }
        }
        if (col.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(ExplodeEffect, transform.position, transform.rotation);
        }
        if (col.tag == "Asteroid")
        {
            Destroy(gameObject);
            Instantiate(ExplodeEffect, transform.position, transform.rotation);
        }

    }
}
