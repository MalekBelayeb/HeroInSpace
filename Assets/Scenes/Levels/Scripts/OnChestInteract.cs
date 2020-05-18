using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnChestInteract : MonoBehaviour
{

    public GameObject levelOne;
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

        levelOne.GetComponent<LevelValidator>().LevelOk = true;
        
    }


}
