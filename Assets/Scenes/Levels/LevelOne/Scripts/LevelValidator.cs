using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelValidator : MonoBehaviour
{
    // Start is called before the first frame update

    public bool LevelOk ;

    private void Start()
    {
        LevelOk = false;
    }


    private void Update()
    {
        if(LevelOk)
        {
            PlayerPrefs.SetInt("LastLevelUnlocked", 2);
            SceneManager.LoadScene("OnLevelSuccess");
        }
    }

}
