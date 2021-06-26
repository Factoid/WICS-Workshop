using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    public ScoreManager scoreMananger;

    [SerializeField]
    private int amount;

    private void OnDestroy()
    {
        scoreMananger.Score += amount;
    }
}
