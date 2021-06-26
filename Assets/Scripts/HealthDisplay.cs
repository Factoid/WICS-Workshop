using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField]
    private HealthManager healthManager;
    [SerializeField]
    private Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = healthManager.NormalizedHealth;
    }
}
