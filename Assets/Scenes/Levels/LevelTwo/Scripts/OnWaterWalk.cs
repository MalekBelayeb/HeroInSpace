using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWaterWalk : MonoBehaviour
{

    float intial_forward_speed ;
    float intial_back_speed ;
    float intial_side_speed;


    public float ForwardSpeedOnWater;
    public float BackSpeedOnWater;
    public float SideSpeedOnWater;

    // Start is called before the first frame update
    void Start()
    {

        intial_forward_speed = GetComponent<PlayerController>().movement.forwardSpeed;
        intial_back_speed = GetComponent<PlayerController>().movement.backSpeed;
        intial_side_speed = GetComponent<PlayerController>().movement.sideSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Water")
        {
            if (gameObject.GetComponent<PlayerController>())
            {
                
                gameObject.GetComponent<PlayerController>().movement.forwardSpeed = ForwardSpeedOnWater;
                gameObject.GetComponent<PlayerController>().movement.backSpeed = BackSpeedOnWater;
                gameObject.GetComponent<PlayerController>().movement.sideSpeed = SideSpeedOnWater;
            }
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Water")
        {
            if (gameObject.GetComponent<PlayerController>())
            {
                gameObject.GetComponent<PlayerController>().movement.forwardSpeed = intial_forward_speed;
                gameObject.GetComponent<PlayerController>().movement.backSpeed = intial_back_speed;
                gameObject.GetComponent<PlayerController>().movement.sideSpeed = intial_side_speed;
            }
        }
    }

}
