using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;

    private void Update()
    {
        setLineLeftMovement();
    }

    private void setLineLeftMovement()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
