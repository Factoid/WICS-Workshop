using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //[SerializeField]
    //private float rotSpeed = ;

    private float yaw;
    private float pitch;
    // Update is called once per frame

    void Update()
    {
        pitch -= Input.GetAxis("Mouse Y");
        yaw += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.identity;
        transform.Rotate( pitch, yaw, 0 );
    }
}
