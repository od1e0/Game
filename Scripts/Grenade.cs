using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject grenade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Transform grenade_move = Instantiate(grenade.transform, gameObject.transform.position, Quaternion.identity);
            grenade_move.GetComponent<Rigidbody>().AddForce(transform.forward * 1500);
        }
        
    }
}
