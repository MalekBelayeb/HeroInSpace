using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnChestValidate : MonoBehaviour
{

    public GameObject player;

    public GameObject levelOne;

    public GameObject crystalGenerator;


    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {

        if (crystalGenerator.GetComponent<CrystalController>().IsDestroyed && levelOne.GetComponent<LevelValidator>().LevelOk)
        {

            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            
        }
        else
        {

           transform.GetChild(0).gameObject.SetActive(true);
           transform.GetChild(1).gameObject.SetActive(false);

        }

    }


    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(int.Parse(player.GetComponent<ItemManager>().itemList[0].itemCount));
        Debug.Log(int.Parse(player.GetComponent<ItemManager>().itemList[1].itemCount));

        if (int.Parse(player.GetComponent<ItemManager>().itemList[0].itemCount) == player.GetComponent<ItemManager>().itemList[0].maximumItemLimit && int.Parse(player.GetComponent<ItemManager>().itemList[1].itemCount) == player.GetComponent<ItemManager>().itemList[1].maximumItemLimit)
        {

            levelOne.GetComponent<LevelValidator>().LevelOk = true;

        }


    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
