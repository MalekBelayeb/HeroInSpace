using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGenerators : MonoBehaviour
{

    public GameObject MainGenerator;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (MainGenerator.GetComponent<GenerateFinalEnemies>().generateEnemies == false)
        {
            activateGenerators();
        } 

    }


    public void activateGenerators()
    {
        for(int i =0;i<gameObject.transform.childCount;i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
