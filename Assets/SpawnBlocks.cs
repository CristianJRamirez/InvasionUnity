using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {
	public GameObject block;
	
	public float interval = 1;

	void Start ()
	{
		Instantiate(block, transform.position, Quaternion.identity);
	//InvokeRepeating("SpawnNext",interval,interval);
	}

	void SpawnNext()
	{
		Instantiate(block, transform.position, Quaternion.identity);
	}
}
