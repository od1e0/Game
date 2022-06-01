using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody player;

    bool is_ground = false;          
    public float force = 6;     

    void Start()
    {

    }

    void OnTriggerStay(Collider col)
    {              
        if (col.tag == "ground") is_ground = true;      
    }
    void OnTriggerExit(Collider col)
    {             
        if (col.tag == "ground") is_ground = false;     
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
            player.AddForce(Vector2.up * force, ForceMode.Impulse);
        
    }
}
