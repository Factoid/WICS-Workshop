using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRefill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var pf = other.GetComponent<PlayerFire>();
        if (pf == null) return;

        pf.Reload();
        Destroy(gameObject);
    }
}
