using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnContact : MonoBehaviour, IDamageSource
{
    [SerializeField]
    private GameObject explosionPrefab;
    [SerializeField]
    private int damage = 5;

    public int Damage => damage;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (explosionPrefab != null)
        {
            var obj = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(obj, 0.25f);
        }

        var dmgSink = collision.gameObject.GetComponent<IDamageSink>();
        if (dmgSink != null) dmgSink.TakeDamage(this);
    }
}
