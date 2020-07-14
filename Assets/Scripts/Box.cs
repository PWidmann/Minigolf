﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // AABB
    public Bounds bounds;
    public float bounciness = 1f;

    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();

        // Get box bounding from renderer for world position
        bounds = renderer.bounds;
    }
    
    void FixedUpdate()
    {
        bounds = renderer.bounds;
    }
}