using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float timeLimit = 60.0f;

    [SerializeField]
    private UnityEvent GameOver;

    public float TimeLeft { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        TimeLeft = timeLimit;   
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if( TimeLeft <= 0 )
        {
            GameOver.Invoke();
            enabled = false;
        }
    }
}
