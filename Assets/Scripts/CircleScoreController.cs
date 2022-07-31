using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int _score = 0;

    public void IncreaseScoreValue()
    {
        _score++;
        setScoreText();
    }

    private void setScoreText()
    {
        scoreText.text = _score.ToString();
    }
}
