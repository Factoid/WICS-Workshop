using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private int numberToSpawn;
    [SerializeField]
    private AreaSpawner spawner;

    private void Awake()
    {
        if (scoreManager == null) scoreManager = GetComponent<ScoreManager>();
        if (gameManager == null) gameManager = GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        for( var i = 0; i < numberToSpawn; ++i )
        {
            var go = spawner.SpawnAndReturn();
            var sc = go.GetComponent<ScoreChanger>();
            sc.scoreMananger = scoreManager;
            var tc = go.GetComponent<TimeChanger>();
            tc.gameManager = gameManager;
        }    
    }
}
