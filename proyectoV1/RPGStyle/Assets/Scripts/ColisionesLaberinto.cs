using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesLaberinto : MonoBehaviour {

	//variable para la posicion inicial
	Vector2 posicionIni;



	// Use this for initialization
	void Start () {

        //inicializa la variable en una posicion
		posicionIni = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // metodo que es llamado cuando el personaje colisiona con un enemigo
	void OnCollisionEnter (Collision otro)
	{


		if(otro.collider.CompareTag("enemigo"))
		{
			Debug.Log ("entró aca");
			Debug.Log (posicionIni);
		}
	}

}
