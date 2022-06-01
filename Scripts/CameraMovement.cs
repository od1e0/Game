using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform Playerbody;
    [SerializeField] float MouseSensetivity = 1;
    public float x;
    public float z;

    float y = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var xRot = Input.GetAxis("Mouse X");
        var yRot = Input.GetAxis("Mouse Y");

        y -= yRot;
        y = Mathf.Clamp(y, z, x);

        Playerbody.Rotate(new Vector3(0, xRot * MouseSensetivity, 0));
        transform.localRotation = Quaternion.Euler(y * MouseSensetivity, 0, 0);
    }
}