
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDied : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GetComponent<Health>())
        {
            if(GetComponent<Health>().currentHealth==130  )
            {
               // SceneManager.LoadScene("GameOverRetry");
            }
        }
    }


}
