using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
	public GameObject enemy;
 
	
	public float interval = 1;
	public bool start=true;

	void Start ()
	{
		if (start==true)
		{	
			if (Random.Range(0.0f, 10.0f)<3.0f)
			{
				Instantiate(enemy, transform.position, Quaternion.identity);
			}
			start=false;
		}
		if (Random.Range(0.0f, 10.0f)<3.0f)
		{
			InvokeRepeating("SpawnNext",interval,interval);
		}
	}

	void SpawnNext()
	{
		Instantiate(enemy, transform.position, Quaternion.identity);
	}
}
