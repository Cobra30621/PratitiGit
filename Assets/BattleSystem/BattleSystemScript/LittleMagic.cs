﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleMagic : MonoBehaviour
{
    public float timer = 6f;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}