using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private TextMeshProUGUI textMesh;

    // Update is called once per frame
    void LateUpdate()
    {
        textMesh.text = scoreManager.Score.ToString();
    }
}
