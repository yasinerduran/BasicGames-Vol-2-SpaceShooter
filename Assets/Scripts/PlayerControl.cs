using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody physic;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float playerFlightSpeed;
    // Start is called before the first frame update
    public float maxX,minX,maxZ,minZ;
    public float tilt;

    public GameObject bullet;
    public Transform gunOnePosition;
    public Transform gunTwoPosition;
    


    float fireTimer;
    public float fireRate;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        fireTimer = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal,0,vertical);
        physic.velocity = vec * playerFlightSpeed;
        physic.position = new Vector3(
            Mathf.Clamp(physic.position.x, minX, maxX),
            0,
            Mathf.Clamp(physic.position.z,minZ,maxZ)
        );
        physic.rotation = Quaternion.Euler(0,0,physic.velocity.x*-tilt);
        
    }
    bool currentGun = false;
    void Update(){
        if(Input.GetButton("Fire1") && (Time.time-fireTimer)>fireRate){
            fireTimer = Time.time;
            if(currentGun){
                Instantiate(bullet,gunOnePosition.position,Quaternion.identity);
                currentGun = false;
            }
            else{
                Instantiate(bullet,gunTwoPosition.position,Quaternion.identity);
                currentGun = true;
            }
            
        }
    }
}
