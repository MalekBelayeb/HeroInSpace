using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update

    int x = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            x++;
        }

        if(x%2==0)
        {
            ResumeGame();
        }
        else
        {
            pauseGame();
        }

    }


    void pauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        transform.GetChild(0).gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    void ResumeGame()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        transform.GetChild(0).gameObject.SetActive(false);
        Time.timeScale = 1f;


    }


}
