using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherHealing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void healing(bool healAuth)
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Individual"))
        {
            if (go.GetComponent<OtherAIBehavior>().behavior == Behavior.PLAYER_FRIEND)
            {
                go.GetComponent<OtherAIBehavior>().isHealing = healAuth ;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Individual")
        {
            if (collision.collider.gameObject.GetComponent<OtherAIBehavior>().behavior == Behavior.MAIN_PLAYER )
            {
                healing(true);
            }
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Individual")
        {
            if(collision.collider.gameObject.GetComponent<OtherAIBehavior>().behavior == Behavior.MAIN_PLAYER )
            {
                healing(true);
            }
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.GetComponent<OtherAIBehavior>().behavior == Behavior.MAIN_PLAYER  )
        {
           
                healing(false);
                Debug.Log("Nohealing");

           

        }
    }


}
