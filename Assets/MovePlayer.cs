using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {

	public int countVida;
	
	public float speed=5.0f;

	private Rigidbody2D rb;

	public float angle = 2f;	
	public float torque;
	public GameObject disparo; 


	void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	public void Update () {
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		Vector2 dir = new Vector2(h,v);
		GetComponent<Rigidbody2D>().velocity=dir.normalized * speed;

		// si se ha pulsado la tecla T //
		if (Input.GetKeyDown(KeyCode.Q)){
			// gira en el eje de las "y" 90 grados
           // GetComponent<Rigidbody2D>().AddTorque(rb.angularVelocity * -50f, ForceMode2D.Force);
			GetComponent<Rigidbody2D>().AddTorque(1000f);
		}
		if (Input.GetKeyDown(KeyCode.E)){
            //GetComponent<Rigidbody2D>().AddTorque(rb.angularVelocity * -5f, ForceMode2D.Force);
        		GetComponent<Rigidbody2D>().AddTorque(-1000f);
		}

		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(disparo, transform.position, Quaternion.identity); //inicio son las cordenadas donde aparecera la bala
		}*/
	}

	public void OnCollisionEnter2D(Collision2D coll)
	{
		
		if(coll.gameObject.tag=="bulletEnemy")
		{

			countVida = countVida +1;
			print("VIDAS  ->"+ countVida);
			
			if(countVida==2)
			{
				Destroy (GameObject.FindWithTag("Vida3"));
			}
			if(countVida==2)
			{
				Destroy (GameObject.FindWithTag("Vida2"));
			}
			if(countVida==3)
			{
				Destroy (GameObject.FindWithTag("Vida1"));
				Destroy(gameObject);
				//Application.LoadLevel(Application.loadedLevel);
				//Application.Quit();
				//Pause();
				Application.LoadLevel(0);
			}
			Destroy(coll.gameObject);
		}
		
	}

	void Pause () {
		 
		 if (Time.timeScale==1)
		 {
			 Time.timeScale = 0;
		 }
		 else
		 {
			 Time.timeScale = 1;
		 }
	}

}
