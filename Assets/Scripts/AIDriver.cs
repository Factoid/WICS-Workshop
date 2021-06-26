using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDriver : MonoBehaviour
{
    [SerializeField]
    private List<Vector3> waypoints;

    private int currentIndex = 0;
    private const float targetRange = 30.0f;

    private void OnDrawGizmosSelected()
    {
        if (waypoints.Count == 0) return;

        Vector3? prevWp = null;
        foreach( var wp in waypoints )
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(wp, 1.0f);
            if( prevWp.HasValue )
            {
                Gizmos.DrawLine(prevWp.Value, wp);
            }
            prevWp = wp;
        }
        if( prevWp.HasValue ) Gizmos.DrawLine(prevWp.Value, waypoints[0]);

        if (Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(waypoints[currentIndex], targetRange);
        }
    }

    private void Update()
    {
        var curWp = waypoints[currentIndex];
        var toWp = curWp - transform.position;

        transform.forward = Vector3.RotateTowards(transform.forward, toWp, 20 * Time.deltaTime * Mathf.Deg2Rad, 0.0f);
        transform.position += 20 * Mathf.Max(0,Vector3.Dot(transform.forward,toWp.normalized)) * Time.deltaTime * transform.forward ;

        if( toWp.magnitude < targetRange )
        {
            currentIndex += 1;
            currentIndex %= waypoints.Count;
        }
    }
}
