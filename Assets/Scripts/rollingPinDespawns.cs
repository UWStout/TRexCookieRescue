﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingPinDespawns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.gameFail();
        }

        else if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
        }
    }
}