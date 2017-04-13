using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle1 : MonoBehaviour {
	//variables para el movimiento de fichas

	//esta variable determina si se puede mover las fichas o no
	public bool mover;
	//esta variable determina el slot o la ficha donde dejamos el supuesto espacio vacio 
	public Transform slot;
	// variables que guardan la posición de las fichas
	float x;
	float y;

	//variables para verificar el tag del objeto
	public string tagObjeto;

	//variables para modificar el script Aciertos
	public GameObject script;
	Aciertos modificar;

	//Variables para mostrar texto cuando se realiza bien el puzzle
	public GameObject Canvas;
	Text texto;



	// Use this for initialization
	void Start () {

		mover = true;
		tagObjeto = gameObject.tag;
		modificar = script.GetComponent<Aciertos>();

		//coger el componente texto del canvas
		texto = Canvas.GetComponent<Text>();
		texto.text="";
	}

	void Update ()
	{

		if(modificar.puntos == 8 )
		{
			//texto que aparecerá cuando se realize el puzzle correctamente
			texto.text = "Felicidades!! Has ganado el Puzzle";

			// detiene el movimiento del puzzle
			mover = false;

			//ACA VIENEN EL CAMBIO DE ESCENA
		}

	}
	// método para sumar los aciertos
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == tagObjeto)
		{
			// sumar a la variable puntos
			modificar.puntos += 1;
		}
	}
	// método para restar los no aciertos
	void OnTriggerExit (Collider other)
	{
		if (other.tag == tagObjeto)
		{
			// restar a la variable puntos
			modificar.puntos -= 1;
		}
	}
	// método para el movimiento||
	void OnMouseUp ()
	{
		if (mover == true)
		{
			//miramos si la distancia de una ficha con la ficha vacia(la que tiene la estrella) calculada con el vector3 es igual a 1, se puede mover
			if (Vector3.Distance (transform.position, slot.position) == 1)
			{
				//se guarda la posicion de la ficha que se toca
			x = transform.position.x;
			y = transform.position.y;
				//movemos la ficha a el espacio de la ficha con la estrella
				transform.position = new Vector3 (slot.position.x, slot.position.y, 0);
				slot.position = new Vector3 (x, y, 0);
				//|| 
					

					}
				}
			}

}
