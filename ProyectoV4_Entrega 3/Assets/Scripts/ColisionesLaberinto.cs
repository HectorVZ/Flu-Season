using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesLaberinto : MonoBehaviour {

	//variable para la posicion inicial
	Vector2 posicionIni;



	// Use this for initialization
	public void Start () {

        //inicializa la variable en una posicion
		posicionIni = transform.position;

	}
	


    // metodo que es llamado cuando el personaje colisiona con un enemigo
	public void OnCollisionEnter (Collision otro)
	{


		if(otro.collider.CompareTag("enemigo"))
		{
			Debug.Log ("entró aca");
			Debug.Log (posicionIni);
		}
	}

}
