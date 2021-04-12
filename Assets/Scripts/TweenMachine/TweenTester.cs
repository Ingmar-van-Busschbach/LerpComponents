﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTester : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            FindObjectOfType<TweenMachine>().MoveGameObject(gameObject, targetPosition, speed);
    }
}
