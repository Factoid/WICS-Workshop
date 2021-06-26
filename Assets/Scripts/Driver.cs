using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rbody;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 60 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        rbody.velocity = 20 * Input.GetAxis("Vertical") * transform.forward;
    }

    private void FixedUpdate()
    {
        transform.position += Time.fixedDeltaTime * rbody.velocity;
    }
}
