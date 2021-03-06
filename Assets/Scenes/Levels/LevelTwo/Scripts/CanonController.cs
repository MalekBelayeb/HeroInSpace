﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{

    public GameObject player;
    public float DistanceToChasePlayerFrom;
    public float TimeBetweenThrows;
    float x=0f;
    public GameObject EnemyToThrow;
    GameObject CurrEnemyToThrow;
    float distanceFromPlayer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceFromPlayer < DistanceToChasePlayerFrom)
        {
        
            //transform.LookAt(player.transform);
        
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position, Vector3.up), Time.deltaTime * 2.0f);
               
            x += 0.5f;
            if(x > TimeBetweenThrows)
            {
            
                CurrEnemyToThrow = Instantiate(EnemyToThrow, transform.position+new Vector3(0,0.6f,0), Quaternion.identity);
                CurrEnemyToThrow.GetComponent<Rigidbody>().AddForce(transform.forward* 3000 * distanceFromPlayer);
                x = 0f;
            
            }

        }

    }
}
