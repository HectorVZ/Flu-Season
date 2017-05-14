using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLaberinto : MonoBehaviour {

    //variable de tipo string que se va a encargar de capturar el nombre del nivel a cargar
	public string levelToLoad;

	

    //metodo que se encarga de cargar el escenario cuando el player colisione con el objeto cargado con este script
	public void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name == "player")
		{
			SceneManager.LoadScene(levelToLoad);
		}
	}
}
