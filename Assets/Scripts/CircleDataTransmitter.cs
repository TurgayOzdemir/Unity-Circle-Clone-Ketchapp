using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    private CircleInputController _inputController;
    private CircleScoreController _scoreController;

    private void Awake()
    {
        _inputController = GetComponent<CircleInputController>();
        _scoreController = GetComponent<CircleScoreController>();
    }

    public bool GetIsTouch()
    {
        return _inputController.IsTouch;
    }

    public void IncreaseScoreValue()
    {
        _scoreController.IncreaseScoreValue();
    }
}
