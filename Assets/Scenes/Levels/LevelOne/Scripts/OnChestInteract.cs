using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnChestInteract : MonoBehaviour
{
    public GameObject player;

    public GameObject levelOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (int.Parse(player.GetComponent<ItemManager>().itemList[0].itemCount) == player.GetComponent<ItemManager>().itemList[0].maximumItemLimit && int.Parse(player.GetComponent<ItemManager>().itemList[1].itemCount) == player.GetComponent<ItemManager>().itemList[1].maximumItemLimit)
        {
            levelOne.GetComponent<LevelValidator>().LevelOk = true;

        }

    }


}
