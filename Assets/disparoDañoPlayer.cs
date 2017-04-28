using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparoDañoPlayer : MonoBehaviour {

private static int count;
public Text text;

	void Start()
	{
		count=0;
		updateCounter();	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag=="enemy")
		{
			Destroy(coll.gameObject);
			count = count +5 ;
			if (count==10)
		{
			Application.Quit();
		}
			updateCounter();	
		}
		Destroy(gameObject);
	}

	void updateCounter()
	{
		text.text= "Puntos -> " + count;
		print("Puntos -> " + count);
		if (count==10)
		{
			Application.Quit();
		}
	}
}
