using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverNav : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returnToMainMenu()
    {
        SceneManager.LoadScene("Demo 01");
    }


    public void Retry()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
