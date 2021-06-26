using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPrefab;
    [SerializeField]
    private Bounds spawnArea;
    [SerializeField]
    private Color gizmoColor;

    public GameObject SpawnAndReturn()
    {
        Vector3 pos;
        pos.x = Random.Range(spawnArea.min.x, spawnArea.max.x);
        pos.y = Random.Range(spawnArea.min.y, spawnArea.max.y);
        pos.z = Random.Range(spawnArea.min.z, spawnArea.max.z);

        return Instantiate(targetPrefab, pos, Quaternion.identity);
    }

    public void Spawn()
    {
        SpawnAndReturn();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(spawnArea.center, spawnArea.size);
    }
}
