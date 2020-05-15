using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GenerateFinalEnemies : MonoBehaviour
{
    public int max_enemies = 6;
    public Transform spawnPostion;
    public GameObject enemyPrefab;
    GameObject currEnemyPrefab;
    int number_of_enemy_to_generate;
    public  Transform target;
    public GameObject player;

    float time_generation = 0;
    public float time_between_generation = 5f;
    
    public bool generateEnemies = false;
    
    // Start is called before the first frame update
    void Start()
    {
        generateEnemies = true;
    }

    // Update is called once per frame
    void Update()
    {
        generateNewEnemies();
    }


    public void generateNewEnemies()
    {
         number_of_enemy_to_generate = max_enemies - transform.childCount;

         time_generation += 0.02f;


        if (number_of_enemy_to_generate>0 && generateEnemies ) 
        {

          for(int i=0;i<number_of_enemy_to_generate;i++)
            {
                if (time_generation > time_between_generation)
                {
               
                    currEnemyPrefab = Instantiate(enemyPrefab, spawnPostion.transform.position, Quaternion.identity);                
                    currEnemyPrefab.transform.parent = this.gameObject.transform;
                    currEnemyPrefab.GetComponent<OtherAIBehavior>().target = player.transform;
                    currEnemyPrefab.transform.LookAt(target.transform.position);                
                    time_generation = 0f;

                }

            }

           

        }

    }


    public void movingToInitialPosition(GameObject go)
    {
          
    
    
    }



}
