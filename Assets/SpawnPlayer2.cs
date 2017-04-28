using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer2 : MonoBehaviour {

	public GameObject player;
 


	void Start ()
	{
		Instantiate(player, transform.position, Quaternion.identity);
		
	}
}
