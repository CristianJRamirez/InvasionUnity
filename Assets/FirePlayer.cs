using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

public GameObject disparo;
public Transform target;

 public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject g = (GameObject) Instantiate(disparo,transform.position, transform.rotation);
			
			//g.GetComponent<Rigidbody2D>().velocity=g.transform.forward * speed;
		

			g.GetComponent<Rigidbody2D>().AddForce(transform.forward * 400*speed); 
			g.GetComponent<Rigidbody2D>().AddForce(transform.up * 200*speed);

			Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),transform.parent.GetComponent<Collider2D>());


			
		}		
	}


}

/* 
utilizar esto para el angulo de las balas
public Transform target ; // variable a la que asignaremos el objetivo
public Vector3 vel_vec ; 
vel_vec = target.position - transform.position; // Creamos un vector desde el perseguidor
*/