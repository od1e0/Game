using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 20f;
    public float fireRate = 1f;
    public float force = 15f;
    public float range = 15f;
    public Transform bulletSpawn;
    public AudioClip ShotSFX;
    public AudioSource _audioSource;
    public GameObject hitEffect;
    private float nextFire = 0f;

    public Camera _cam;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }    
        
    }

    void Shoot()
    {
        _audioSource.PlayOneShot(ShotSFX);
       
    

        RaycastHit hit;

        if (Physics.Raycast(_cam.transform.position,_cam.transform.forward, out hit, range))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Shoooot!!" + hit);

            GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * force);
            }
        }


    }
}
