using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.score;
    }
}
