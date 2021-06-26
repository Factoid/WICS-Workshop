using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private GameObject targetPrefab;
    [SerializeField]
    private Bounds spawnArea;
    [SerializeField]
    private int numberToSpawn;

    private void Awake()
    {
        if (scoreManager == null) scoreManager = GetComponent<ScoreManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        for( var i = 0; i < numberToSpawn; ++i )
        {
            Vector3 pos;
            pos.x = Random.Range(spawnArea.min.x, spawnArea.max.x);
            pos.y = Random.Range(spawnArea.min.y, spawnArea.max.y);
            pos.z = Random.Range(spawnArea.min.z, spawnArea.max.z);

            var go = Instantiate(targetPrefab, pos, Quaternion.identity);
            var sc = go.GetComponent<ScoreChanger>();
            sc.scoreMananger = scoreManager;
        }    
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(spawnArea.center, spawnArea.size);
    }
}
