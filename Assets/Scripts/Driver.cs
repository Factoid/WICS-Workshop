using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 60 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
    }

    private void FixedUpdate()
    {
        transform.position += 20 * Time.fixedDeltaTime * Input.GetAxis("Vertical") * transform.forward;
    }
}
