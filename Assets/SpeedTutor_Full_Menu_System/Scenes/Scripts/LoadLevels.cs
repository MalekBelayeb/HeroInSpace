﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void startLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void startLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");

    }
}
