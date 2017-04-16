using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesLaberinto : MonoBehaviour {

	//variable para la posicion inicial
	Vector2 posicionIni;



	// Use this for initialization
	void Start () {


		posicionIni = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision otro)
	{


		if(otro.collider.CompareTag("enemigo"))
		{
			Debug.Log ("entró aca");
			Debug.Log (posicionIni);
		}
	}

}
