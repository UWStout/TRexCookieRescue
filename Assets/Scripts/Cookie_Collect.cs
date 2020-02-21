﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_Collect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(collision.gameObject);
        }
    }
}