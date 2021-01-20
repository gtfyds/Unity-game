﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameOgjectWithTag("GM").GetComponent<GameMaster>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.positon;
        }
    }
}