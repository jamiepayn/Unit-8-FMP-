﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public GameObject door;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("col detected");

        if (collision.gameObject.layer == 8)
        {
            Debug.Log("key hit");
            
            Destroy(gameObject);

            Destroy(door);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
