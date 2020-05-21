using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnElevatorCollision : MonoBehaviour
{

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            gameObject.transform.parent = null;
        }


    }


    private void OnTriggerEnter(Collider other)
    {

         if (other.tag == "Elevator")
        {
         gameObject.transform.parent = other.gameObject.transform;
        }
    }


 
    private void OnCollisionStay(Collision collision)
    {
    
       /* if (collision.collider.tag == "Elevator")
        {
            gameObject.transform.parent = collision.collider.gameObject.transform;
        }*/
        
  
    }

    private void OnCollisionExit(Collision collision)
    {
       /* if (collision.collider.tag == "Elevator")
        {
            gameObject.transform.parent = null;
        }*/
    }

 
}
