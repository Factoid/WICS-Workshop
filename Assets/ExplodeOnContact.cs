using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnContact : MonoBehaviour
{
    [SerializeField]
    private GameObject explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (explosionPrefab != null)
        {
            var obj = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(obj, 0.25f);
        }
    }
}
