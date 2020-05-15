using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFall : MonoBehaviour
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

        if(collision.collider.gameObject.GetComponent<OtherAIBehavior>())
        {
            if (collision.collider.gameObject.GetComponent<OtherAIBehavior>().behavior == Behavior.MAIN_PLAYER)

                collision.collider.gameObject.GetComponent<Health>().currentHealth = 130;

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.GetComponent<OtherAIBehavior>())
        {
            if (collision.collider.gameObject.GetComponent<OtherAIBehavior>().behavior == Behavior.MAIN_PLAYER)

                collision.collider.gameObject.GetComponent<Health>().currentHealth = 130;

        }

    }
} 
