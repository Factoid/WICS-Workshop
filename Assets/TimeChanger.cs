using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    [SerializeField]
    private float amount;

    public GameManager gameManager;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        gameManager.AwardTime(amount);
    }
}
