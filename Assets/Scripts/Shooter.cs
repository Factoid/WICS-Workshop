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
    [SerializeField]
    private Rigidbody refFrame;

    // Update is called once per frame
    public void Fire()
    {
        var obj = Instantiate(prefab);
        obj.transform.position = spawnPoint.position;
        obj.transform.forward = spawnPoint.forward;

        var rbody = obj.GetComponent<Rigidbody>();
        rbody.velocity = obj.transform.forward * fireSpeed;
        if( refFrame != null )
        {
            rbody.velocity += refFrame.velocity;
        }
    }
}
