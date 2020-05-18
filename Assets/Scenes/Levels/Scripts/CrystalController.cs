using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalController : MonoBehaviour
{

    public GameObject generator;
    public bool IsDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        IsDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.GetChild(0).GetComponent<OtherAIBehavior>())
        {
            if (transform.GetChild(0).GetComponent<OtherAIBehavior>().hitCount > 9f)
            {
                transform.GetChild(1).gameObject.SetActive(false);
                transform.GetChild(2).gameObject.SetActive(true);
                transform.GetChild(3).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(1).gameObject.SetActive(true);
                transform.GetChild(2).gameObject.SetActive(false);
                transform.GetChild(3).gameObject.SetActive(false);

            }

        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
            generator.GetComponent<GenerateFinalEnemies>().generateEnemies = false;
            IsDestroyed = true;
        }
    }
}
