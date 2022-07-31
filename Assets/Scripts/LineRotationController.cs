using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    [SerializeField] private float _rotationValue = 30f;

    private float _randomRotation;

    private void Start()
    {
        generateRandomRotationValue();
        setLineRotation();
    }

    private void generateRandomRotationValue()
    {
        _randomRotation = Random.Range(-_rotationValue, _rotationValue);
    }

    private void setLineRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, _randomRotation);
    }

}
