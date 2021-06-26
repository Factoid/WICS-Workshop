using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnFire;
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnFire.Invoke();
        }
    }
}
