using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnText : MonoBehaviour {

public Text txt;
 


	void Start ()
	{
		Instantiate(txt, transform.position, Quaternion.identity);
		
	}
	
}
