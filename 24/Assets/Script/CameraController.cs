﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, -10);
    }
}
