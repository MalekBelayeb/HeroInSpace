using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearestIndividual : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

	private void FixedUpdate()
	{
		findNearestTarget();
	}

	public void findNearestTarget()
	{
		GameObject theNearestIndividual =null;
		float prev_dist = Mathf.Infinity;
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("Individual"))
		{
			//MAYJICH FRIEND TARGET MTAA FRIEND OUALA ENEMY TARGET MTAA ENEMY DONC LAZEM IKOUN WITH DIFFERENT BEHAVIOR
			if((go.GetComponent<OtherAIBehavior>().behavior != GetComponent<OtherAIBehavior>().behavior) && go.GetComponent<OtherAIBehavior>().behavior != Behavior.CRYSTAL_GENERATOR)
			{
				float dist = Vector3.Distance(go.transform.position, transform.position);

				if (dist < prev_dist)
				{
					if (dist != 0)
					{

						theNearestIndividual = go;
						prev_dist = dist;

					}

				}
			}
	
		}

		GetComponent<OtherAIBehavior>().target = theNearestIndividual.transform;

	
	}



}
