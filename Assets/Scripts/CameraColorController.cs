using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    private Camera _camera;
    private int _colorIndex = 0;
    private float _currentTime;


    [SerializeField] private Color[] colors;

    [SerializeField] private float time;
    [SerializeField] private float lerpValue;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        changeSmoothCameraColor();
        setColorChangeTime();
    }

    private void changeSmoothCameraColor()
    {
        _camera.backgroundColor = Color.Lerp(_camera.backgroundColor, colors[_colorIndex], lerpValue * Time.deltaTime);
    }

    private void setColorChangeTime()
    {
        if (_currentTime <= 0)
        {
            IncreaseColorIndexValue();
            _currentTime = time;
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }

    private void IncreaseColorIndexValue()
    {
        if (_colorIndex >= colors.Length - 1)
        {
            _colorIndex = 0;
        }
        _colorIndex++;
    }

    private void OnDestroy()
    {
        _camera.backgroundColor = colors[0];
    }
}
