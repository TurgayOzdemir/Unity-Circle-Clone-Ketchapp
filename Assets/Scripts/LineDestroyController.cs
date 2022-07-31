using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endValue = -5f;

    private void Update()
    {
        checkLinePositionX();
    }

    private void checkLinePositionX()
    {
        if (transform.position.x <= endValue)
        {
            Destroy(gameObject);
        }
    }
}
