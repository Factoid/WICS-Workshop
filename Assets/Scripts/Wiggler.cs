using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggler : MonoBehaviour
{
    [SerializeField]
    private Vector3 dir;
    [SerializeField]
    private float rate;

    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPos + dir * Mathf.Sin(Time.time * rate); 
    }
}
