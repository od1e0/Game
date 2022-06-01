using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 10;
    [SerializeField] float TurningSpeed = 60;
    [SerializeField] float Force = 6;
   
    Vector3 m_Movement;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * TurningSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;

        //Debug.Log(new Vector3(horizontal, 0f, vertical));

        m_Movement.Set(horizontal, 0f, vertical);

        transform.Translate(m_Movement * Time.deltaTime * MovementSpeed);

        if (Input.GetKey(KeyCode.Space)) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * Force, ForceMode.Impulse);
        }


    }
}