using System.Collections;
using System.Collections.Generic;
using UnityEngine; 	
using UnityEngine.UI;

public class disparoDañoEnemy : MonoBehaviour {



	void Start() {

    }

	void OnCollisionEnter2D(Collision2D coll)
	{

		Destroy(gameObject);
	}


	
}
