using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour {
	//variables para el cambio de cámara
	public camera cam1;
	public camera cam2;

	// Use this for initialization
	void Start () {
		// la cam1 es la que va a estar habilitada
		cam1.GetComponent<Camera> ().enable = true;
		// la cam2 va a estar deshabilitada
		cam2.GetComponent<Camera> ().enable = false;

	}
	
	// Update is called once per frame
	void Update () {
		//Cuando se presione la tecla c
		if(Input.GetKeyDown("c"))
		{
			//preguntar si la cam1 está habilitada
			if(cam1.GetComponent<Camera>().enable==true)
			{
				//En caso de estar habilitada la cm1 entonces la deshabilita y habilita la cam2
				cam1.GetComponent<Camera> ().enable = false;
				cam2.GetComponent<Camera> ().enable = true;
			}	
			//preguntar si la cam2 está habilitada
			else if (cam2.GetComponent<Camera>().enable==true)
			{
				//En caso de estar habilitada la cm2 entonces la deshabilita y habilita la cam1
				cam2.GetComponent<Camera> ().enable = false;
				cam1.GetComponent<Camera> ().enable = true;
			}
		}		
	}
}
