using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    private CircleDataTransmitter _circleDataTransmitter;
    private Rigidbody2D _rb;

    [SerializeField] private float circleJumpForce = 1f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _circleDataTransmitter = GetComponent<CircleDataTransmitter>();
    }

    private void FixedUpdate()
    {
        SetCircleJump();
    }

    private void SetCircleJump()
    {
        if (_circleDataTransmitter.GetIsTouch())
        {
            _rb.velocity = Vector2.up * circleJumpForce * Time.fixedDeltaTime;
        }
        
    }
}
