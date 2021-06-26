using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float yaw;
    private float pitch;
    // Update is called once per frame
    void Update()
    {
        pitch += 60 * Time.deltaTime * Input.GetAxis("Vertical");
        yaw += 60 * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.localRotation = Quaternion.identity;
        transform.Rotate( pitch, yaw, 0 );
    }
}
