using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continiousVelocity : MonoBehaviour {

	public int speed;
	//public Vector2 velocity;
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody2D>().velocity=new Vector2 (0,speed);
	}

}
