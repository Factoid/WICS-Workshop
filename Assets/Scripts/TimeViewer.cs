using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeViewer : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private TextMeshProUGUI textMesh;

    // Update is called once per frame
    void LateUpdate()
    {
        textMesh.text = gameManager.TimeLeft.ToString("F0");
    }
}
