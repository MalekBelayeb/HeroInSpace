using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelValidator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject chest;
    public GameObject crystalGenerator;

    public bool LevelOk = false;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(LevelOk);
        if(crystalGenerator.GetComponent<CrystalController>().IsDestroyed)
        {
            chest.transform.GetChild(0).gameObject.SetActive(false);
            chest.transform.GetChild(1).gameObject.SetActive(true);

        }
        else
        {
            chest.transform.GetChild(0).gameObject.SetActive(true);
            chest.transform.GetChild(1).gameObject.SetActive(false);

        }
    }
}
