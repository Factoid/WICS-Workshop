using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnFire;

    public void Reload()
    {
        curAmmo = 10;
    }

    public int curAmmo { get; private set; } = 10;
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButtonDown("Fire1") && curAmmo > 0 )
        {
            --curAmmo;
            OnFire.Invoke();
        }
    }
}
