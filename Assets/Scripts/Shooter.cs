using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float fireSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1") )
        {
            var obj = Instantiate(prefab);
            obj.transform.position = spawnPoint.position;
            obj.transform.forward = spawnPoint.forward;

            var rbody = obj.GetComponent<Rigidbody>();
            rbody.velocity = obj.transform.forward * fireSpeed;
        }
    }
}
