﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "End") {
            Application.LoadLevel("level2");
        }
        if (other.gameObject.name == "enemy") {
            Application.LoadLevel("level2");
        }
    }
}
