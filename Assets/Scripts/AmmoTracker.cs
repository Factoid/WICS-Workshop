using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmmoTracker : MonoBehaviour
{
    [SerializeField]
    private List<Image> pips;

    [SerializeField]
    private PlayerFire ammoSource;

    // Update is called once per frame
    void Update()
    {
        int n = ammoSource.curAmmo;
        for( int i = 0; i < pips.Count; ++i )
        {
            pips[i].enabled = i < n;
        }
    }
}
