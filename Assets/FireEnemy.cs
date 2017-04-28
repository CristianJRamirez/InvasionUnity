using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour {

	public GameObject bullet;

	public float interval=2;

	public Transform target ; // variable a la que asignaremos el enemy que dispara

 	public float speed;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Fire",interval,interval);
	}

	void Fire()
	{
		GameObject g = (GameObject)Instantiate(bullet,transform.position,transform.rotation);

		g.GetComponent<Rigidbody2D>().AddForce(transform.forward * 400*-speed); 
		g.GetComponent<Rigidbody2D>().AddForce(transform.up * 200*-speed);
		Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),transform.parent.GetComponent<Collider2D>());



		
	}

}

