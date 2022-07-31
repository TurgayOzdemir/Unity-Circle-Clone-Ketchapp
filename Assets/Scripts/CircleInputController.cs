using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CircleInputController : MonoBehaviour
{

    private CircleDataTransmitter _dataTransmitter;

    private PlayerInput _playerInput;
    private InputAction _clickAction;

    public bool IsTouch = false;

    private void Awake()
    {
        _dataTransmitter = GetComponent<CircleDataTransmitter>();

        _playerInput = GetComponent<PlayerInput>();
        _clickAction = _playerInput.actions["Click"];
    }

    private void OnEnable()
    {
        _clickAction.started += _ => clickDown();
        _clickAction.canceled += _ => clickUp();
    }

    private void OnDisable()
    {
        _clickAction.performed -= _ => clickDown();
        _clickAction.canceled += _ => clickUp();
    }

    private void clickDown()
    {
        IsTouch = true;
        _dataTransmitter.IncreaseScoreValue();
    }
    private void clickUp()
    {
        IsTouch = false;
    }

}
