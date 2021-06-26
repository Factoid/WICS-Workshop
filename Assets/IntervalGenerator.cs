using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntervalGenerator : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnInterval;
    [SerializeField]
    private float maxInterval;
    [SerializeField]
    private float initialDelay;

    private float nextInterval;

    private void Start()
    {
        nextInterval = initialDelay;    
    }

    private void Update()
    {
        if( Time.time > nextInterval )
        {
            OnInterval.Invoke();
            nextInterval = Time.time + maxInterval;
        }
    }
}
