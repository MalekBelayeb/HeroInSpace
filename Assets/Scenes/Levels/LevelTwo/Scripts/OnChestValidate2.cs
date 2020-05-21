using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnChestValidate2 : MonoBehaviour
{
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
        if(collision.gameObject.GetComponent<ItemManager>())
        {

            if(int.Parse(collision.gameObject.GetComponent<ItemManager>().itemList[0].itemCount) == collision.gameObject.GetComponent<ItemManager>().itemList[0].maximumItemLimit && int.Parse(collision.gameObject.GetComponent<ItemManager>().itemList[1].itemCount) == collision.gameObject.GetComponent<ItemManager>().itemList[1].maximumItemLimit)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }

}
