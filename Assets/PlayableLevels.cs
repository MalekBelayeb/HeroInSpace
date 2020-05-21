using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayableLevels : MonoBehaviour
{
    int LastLevelUnlocked;
    // Start is called before the first frame update
    void Start()
    {

        LastLevelUnlocked = PlayerPrefs.GetInt("LastLevelUnlocked", 1);
        disableAll();
        
        for (int i = 0; i < LastLevelUnlocked; i++)
        {

            Debug.Log(i);
            transform.GetChild(0).GetChild(i).GetComponent<Button>().interactable = true;

        }

    }

   

    public void disableAll()
    {
        for (int i = 0; i < transform.childCount-1; i++)
        {

            transform.GetChild(0).GetChild(i).GetComponent<Button>().interactable = false;

        }

    }
}
