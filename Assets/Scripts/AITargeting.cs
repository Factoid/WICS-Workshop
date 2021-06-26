using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITargeting : MonoBehaviour
{
    [SerializeField]
    private Transform rotator;

    [SerializeField]
    private Shooter shooter;

    private float nextFire;
    private Transform currentTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentTarget = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentTarget = null;
        }
    }

    private void LateUpdate()
    {
        if (currentTarget == null) return;

        var toTarget = currentTarget.position - rotator.position;
        var newForward = Vector3.RotateTowards(rotator.forward, toTarget, 60 * Time.deltaTime * Mathf.Deg2Rad, 0.0f);
        rotator.forward = newForward;

        if (Vector3.Angle(toTarget,rotator.forward) < 2.0f )
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + 2.0f;
                shooter.Fire();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (currentTarget == null) return;
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, currentTarget.position);
        Gizmos.DrawWireSphere(currentTarget.position, 2.0f);
    }
}
