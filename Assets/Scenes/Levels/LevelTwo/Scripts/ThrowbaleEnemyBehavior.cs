﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowbaleEnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Individual")
        {
            Destroy(gameObject);
        }
    }
}