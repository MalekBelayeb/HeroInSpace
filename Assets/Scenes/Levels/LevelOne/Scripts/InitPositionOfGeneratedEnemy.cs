using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPositionOfGeneratedEnemy : MonoBehaviour
{

    public Transform target;
   public bool generated=false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (generated)
            setPosition();
    }

    public void setPosition()
    {

        transform.Translate(target.position);

    }
}
