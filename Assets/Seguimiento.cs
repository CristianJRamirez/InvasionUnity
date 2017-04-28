using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour {



 Transform target ; // variable a la que asignaremos el objetivo
Vector3 vel_vec ; // variable donde guardaremos el vector que apunta de uno a otro
public float speed ; // variable para la velocidad de seguimiento

void Start()
{
    target= GameObject.FindWithTag ("player").transform;
}

void Update()
{
        if (target !=null)
        {
        Vector3 toTargetVector = target.position - transform.position;

        //transform.LookAt(target);
        float zRotation = ( Mathf.Atan2( toTargetVector.y, toTargetVector.x )*Mathf.Rad2Deg ) +90.0f;
        transform.rotation = Quaternion.Euler(new Vector3 ( 0, 0, zRotation));


        GetComponent<Rigidbody2D>().velocity=toTargetVector/4;
        }
        
       // enemy.GetComponent<Rigidbody2D>().AddForce(transform.forward * 400*speed); 
		//enemy.GetComponent<Rigidbody2D>().AddForce(transform.up * 200*speed);

}

} 



