using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 2f;          // Speed of movement
    public float moveRange = 5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newX = Mathf.Sin(Time.time * speed) * (moveRange / 2);
        transform.position = startPosition + new Vector3(newX, 0, 0);
    }
}
