﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnElevatorCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Elevator")
        {
            gameObject.transform.parent = collision.collider.gameObject.transform;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Elevator")
        {
            gameObject.transform.parent = collision.collider.gameObject.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Elevator")
        {
            gameObject.transform.parent = null;
        }
    }
}